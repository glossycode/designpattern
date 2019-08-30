using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{

    public interface IBanque
    {
        event EventHandler CasseDuSiecle;
        string Nom { get; set; }
        double ObtenirSoldeCompte(int idCompte);
    }


    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
