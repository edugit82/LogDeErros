using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Teste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            LogDeErros.LogDeErros.Log(() => 
            {
                decimal dividendo = 10;
                decimal divisor = 0;

                decimal resultado = dividendo / divisor;
            });            
        }
    }
}
