using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyExperiments;
using Moq;


namespace MyTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var mock = new Mock<IAnimal>();
            mock.Setup(a => a.CanRun()).Returns(true);

            mock.Verify();
            //Assert.IsTrue(false);

        }
    }
}
