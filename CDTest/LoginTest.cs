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
    public class LoginTests
    {
        private Login _login;
        private Mock<IServicesBase<Account>> _mockServicesBase;

        [SetUp]
        public void SetUp()
        {
            _mockServicesBase = new Mock<IServicesBase<Account>>();
            _login = new Login();
        }

        [Test]
        public void TestLogin_InvalidUser()
        {
            var users = new List<Account> {
                new Account { UserName = "admin", PassWord = "admin", RoleId = "MG" },
                new Account { UserName = "user", PassWord = "user", RoleId = "EMP" }
            };

            _mockServicesBase.Setup(x => x.GetAll()).Returns(users.AsQueryable());

            var mockAccountService = new AccountService(_mockServicesBase.Object);

            var loginForm = new Login();
            loginForm._userServices = mockAccountService;

            var result = loginForm.IsValidUser("invalid", "password");

            Assert.IsFalse(result);
        }

        [Test]
        public void TestLogin_ValidUser()
        {
            var users = new List<Account> {
                new Account { UserName = "admin", PassWord = "admin", RoleId = "MG" },
                new Account { UserName = "user", PassWord = "user", RoleId = "EMP" }
            };

            _mockServicesBase.Setup(x => x.GetAll()).Returns(users.AsQueryable());

            var mockAccountService = new AccountService(_mockServicesBase.Object);

            var loginForm = new Login();
            loginForm._userServices = mockAccountService;

            var result = loginForm.IsValidUser("admin", "admin");

            Assert.IsTrue(result);
        }
    }
}
