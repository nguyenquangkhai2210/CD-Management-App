using CD_Management_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDTest
{
    [TestFixture]
    public class AlbumManagementTests
    {
        private AlbumManagement _albumManagement;

        [SetUp]
        public void Setup()
        {
            _albumManagement = new AlbumManagement();
        }

        [Test]
        [TestCase("123", ExpectedResult = true)]
        [TestCase("1.23", ExpectedResult = false)]
        [TestCase("abcd", ExpectedResult = false)]
        public bool Test_CheckNumRegex(string input)
        {
            return _albumManagement.checkNumRegex(input);
        }
    }
}
