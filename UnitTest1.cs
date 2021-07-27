using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day20_UserRegistrationProblem;

namespace UserTest
{
    class UnitTest1
    {
        private readonly RegisterUser registerUser;
        public UnitTest1()
        {
            registerUser = new RegisterUser();
        }
        [TestMethod]
        public void TestMethod1()
        {
            var result = RegisterUser.validateMobileNo("+91 70403911139");
            Assert.AreEqual(true, result);
        }
    }
}
