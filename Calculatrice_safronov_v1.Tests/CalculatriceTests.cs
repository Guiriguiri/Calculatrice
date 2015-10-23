using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculatrice_safronov;

namespace Calculatrice_safronov.Tests
{
    [TestClass]
    public class CalculatriceTests
    {
        [TestMethod]
        public void Ajout()
        {
            Ajouter sum = new Ajouter();
            
            decimal var1, var2;
            decimal res;
            var1 = 8;
            var2 = 4;
            sum.Operande1 = var1;
            sum.Operande2 = var2;
            res = sum.Calculer();
        }

        [TestMethod]
        public void Soustraction()
        {
            Soustraire sum = new Soustraire();

            decimal var1, var2;
            decimal res;
            var1 = 8;
            var2 = 4;
            sum.Operande1 = var1;
            sum.Operande2 = var2;
            res = sum.Calculer();
        }

        [TestMethod]
        public void Multiplication()
        {
            Multiplier sum = new Multiplier();
            decimal var1, var2;
            decimal res;
            var1 = 8;
            var2 = 4;
            sum.Operande1 = var1;
            sum.Operande2 = var2;
            res = sum.Calculer();
        }

        [TestMethod]
        public void Division()
        {
            Diviser sum = new Diviser();
            decimal var1, var2;
            decimal res;
            var1 = 8;
            var2 = 2;
            sum.Operande1 = var1;
            sum.Operande2 = var2;
            res = sum.Calculer();
        }

        [TestMethod]
        public void DoubleCarre()
        {
            Carre sum = new Carre();
            decimal var1, var2;
            decimal res;
            var1 = 8;
            var2 = 2;
            sum.Operande1 = var1;
            sum.Operande2 = var2;
            res = sum.Calculer();
        }
    }
}
