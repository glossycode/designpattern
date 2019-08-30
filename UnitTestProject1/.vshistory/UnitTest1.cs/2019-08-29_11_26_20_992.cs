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
            var mock = new Mock<IBanque>();

            // lire "dès que la propriété 'Nom' est accédée en lecture,
            // - retourner Société Géniale"
            // - et effectuer le code de callback"
            //   (on aurait pu indiquer une méthode au lieu d'une lambda)
            mock.SetupGet(b => b.Nom)
                .Returns("Société Géniale")
                .Callback(
                     () => Console.WriteLine("callback du mock")
                );

            // lire "dès que la fonction 'ObtenirSoldeCompte' est appellée,
            // - pour n'importe qu'elle valeur de id, retourne 15000
            //   (on aurait pu indiquer une valeur fixe, un regex ou un range)
            // - et lance l'évènement CasseDuSiecle"
            mock.Setup(b => b.ObtenirSoldeCompte(It.IsAny<int>()))
                      .Returns(15000.0)
                      .Raises(b => b.CasseDuSiecle += null, null, EventArgs.Empty);

            // On obtient notre instance 'factice' de IBanque
            IBanque banque = mock.Object;

            // Imaginons l'utilisation du mock par des objets réels:
            banque.CasseDuSiecle +=
                new EventHandler(
                   (s, a) => Console.WriteLine("C'est le casse du siècle!")
                );
            Console.WriteLine(banque.Nom);
            Console.WriteLine(banque.ObtenirSoldeCompte(45654));

            // Retour à notre contexte de test, vérifions que l'appel à 
            // 'Nom' a bien été effectué exactement une fois
            mock.VerifyGet(b => b.Nom, Times.Once());
        }
    }
}
