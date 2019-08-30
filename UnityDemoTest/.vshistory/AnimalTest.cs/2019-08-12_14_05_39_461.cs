using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using UnityDemo;

namespace UnityDemoTest
{
    [TestClass]
    public class AnimalTest
    {
        [TestMethod]
        public void Test_running()
        {
            var mock = Mock<IAnimal>();
        }
    }
}
