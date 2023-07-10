using CD_Management_System;
using Moq;
using Repository.Models;
using Repository.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDTest
{
    [TestFixture]
    public class EmployeeManagementTests
    {
        private Mock<IServicesBase<Account>> _mockServicesBase;
        private AccountService _accountService;
        private EmployeeManagement _employeeManagement;

        [SetUp]
        public void Setup()
        {
            _mockServicesBase = new Mock<IServicesBase<Account>>();
            _accountService = new AccountService(_mockServicesBase.Object);
            _employeeManagement = new EmployeeManagement();
            _employeeManagement._accountService = _accountService;

        }

        [Test]
        public void TestClickBtn_CallsServicesBaseCreate()
        {
            var account = new Account
            {
                UserName = "user1",
                FullName = "User 1",
                Email = "user1@example.com",
                Address = "123 Street",
                PhoneNumber = "0325575555",
                PassWord = "password1",
                RoleId = "EM"
            };

            _mockServicesBase.Setup(m => m.Create(It.IsAny<Account>()));

            _employeeManagement.txtUserName.Text = account.UserName;
            _employeeManagement.txtFullName.Text = account.FullName;
            _employeeManagement.txtEmail.Text = account.Email;
            _employeeManagement.txtAddress.Text = account.Address;
            _employeeManagement.txtPhoneNumber.Text = account.PhoneNumber;
            _employeeManagement.txtPassword.Text = account.PassWord;

            _employeeManagement.btnCreate_click(null, EventArgs.Empty);

            _mockServicesBase.Verify(m => m.Create(It.Is<Account>(
                a => a.UserName == account.UserName &&
                     a.FullName == account.FullName &&
                     a.Email == account.Email &&
                     a.Address == account.Address &&
                     a.PhoneNumber == account.PhoneNumber &&
                     a.PassWord == account.PassWord &&
                     a.RoleId == account.RoleId
            )), Times.Once);
        }
    }
}
