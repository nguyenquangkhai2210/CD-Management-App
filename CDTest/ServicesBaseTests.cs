using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
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
    public class ServicesBaseTests
    {
        private Mock<CDStoreContext> _mockContext;
        private Mock<DbSet<Account>> _mockDbSet;
        private ServicesBase<Account> _servicesBase;

        [SetUp]
        public void Setup()
        {
            _mockContext = new Mock<CDStoreContext>();
            _mockDbSet = new Mock<DbSet<Account>>();

            _mockContext.Setup(c => c.Set<Account>()).Returns(_mockDbSet.Object);

            _servicesBase = new ServicesBase<Account>(_mockContext.Object);
        }

        [Test]
        public void TestCreate_AddsEntityToDbSet()
        {
            var newAccount = new Account { UserName = "user1", PassWord = "password1", RoleId = "role1" };

            _servicesBase.Create(newAccount);

            _mockDbSet.Verify(d => d.Add(newAccount), Times.Once);

            _mockContext.Verify(c => c.SaveChanges(), Times.Once);
        }

        [Test]
        public void TestRemove_RemovesEntityFromDbSet()
        {
            var entity = new Account();

            var result = _servicesBase.Remove(entity);

            _mockDbSet.Verify(m => m.Remove(entity), Times.Once);
            _mockContext.Verify(m => m.SaveChanges(), Times.Once);

            Assert.IsTrue(result);
        }

        [Test]
        public void TestRemove_ReturnsFalseIfExceptionThrown()
        {
            var entity = new Account();

            _mockDbSet.Setup(m => m.Remove(entity)).Throws(new Exception());

            var result = _servicesBase.Remove(entity);

            _mockDbSet.Verify(m => m.Remove(entity), Times.Once);
            _mockContext.Verify(m => m.SaveChanges(), Times.Never);
            Assert.IsFalse(result);
        }

    }
}
