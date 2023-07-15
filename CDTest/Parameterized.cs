using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using Repository.Models;
using Repository.Services;
using System.Text.RegularExpressions;

namespace CD_Management_System.Tests
{
    [TestFixture]
    public class EmployeeValidationTests
    {
        [TestCase("", "John Doe", "john@example.com", "123 Main St", "1234567890", "password", false, TestName = "Missing UserName")]
        [TestCase("john123", "", "john@example.com", "123 Main St", "1234567890", "password", false, TestName = "Missing FullName")]
        [TestCase("john123", "John Doe", "", "123 Main St", "1234567890", "password", false, TestName = "Missing Email")]
        [TestCase("john123", "John Doe", "john@example.com", "", "1234567890", "password", false, TestName = "Missing Address")]
        [TestCase("john123", "John Doe", "john@example.com", "123 Main St", "", "password", false, TestName = "Missing PhoneNumber")]
        [TestCase("john123", "John Doe", "john@example.com", "123 Main St", "1234567890", "", false, TestName = "Missing Password")]
        [TestCase("john123", "John Doe", "invalidemail", "123 Main St", "1234567890", "password", false, TestName = "Invalid Email Format")]
        [TestCase("john123", "John Doe", "john@example.com", "123 Main St", "invalidphone", "password", false, TestName = "Invalid Phone Number Format")]
        [TestCase("john123", "John Doe", "john@example.com", "123 Main St", "1234567890", "password", true, TestName = "Valid Employee")]
        public void CreateEmployee_ValidatesInput(string userName, string fullName, string email, string address, string phoneNumber, string password, bool expectedResult)
        {
            Account account = new Account();
            account.UserName = userName;
            account.FullName = fullName;
            account.Email = email;
            account.Address = address;
            account.PhoneNumber = phoneNumber;
            account.PassWord = password;

            bool result = EmployeeValidator.IsValidEmployee(account);

            Assert.AreEqual(expectedResult, result);
        }
    }

    public class EmployeeValidator
    {
        public static bool IsValidEmployee(Account account)
        {
            if (string.IsNullOrEmpty(account.UserName)
                || string.IsNullOrEmpty(account.FullName)
                || string.IsNullOrEmpty(account.Email)
                || string.IsNullOrEmpty(account.Address)
                || string.IsNullOrEmpty(account.PhoneNumber)
                || string.IsNullOrEmpty(account.PassWord))
            {
                return false;
            }

            if (!emailRegex(account.Email))
            {
                return false;
            }

            if (!phoneNumberRegex(account.PhoneNumber))
            {
                return false;
            }
            return true;
        }

        private static bool emailRegex(string email)
        {
            var regex = new Regex("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$");
            bool valid = true;
            if (email.Equals(""))
            {
                valid = false;
            }
            if (!regex.IsMatch(email))
            {
                valid = false;
            }
            else
            {
                valid = true;
            }
            return valid;
        }

        private static bool phoneNumberRegex(string phoneNumber)
        {
            var regex = new Regex("^\\(?([0]{1})\\)?[-. ]?([0-9]{9})$");
            bool valid = true;
            if (phoneNumber.Equals(""))
            {
                valid = false;
            }
            if (!regex.IsMatch(phoneNumber))
            {
                valid = false;
            }
            else
            {
                valid = true;
            }
            return valid;
        }
    }
}
