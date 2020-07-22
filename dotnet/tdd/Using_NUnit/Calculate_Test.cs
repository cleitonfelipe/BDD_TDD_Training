using NUnit.Framework;

namespace Using_NUnit
{
    [TestFixture]
    public class Calculate_Test
    {
        [Test]
        public void Somar_2_valores()
        {
            // Arrange
            var calc = new Calculate();

            //Act 
            var result = calc.Somar(2, 2);
            
            //Assert
            Assert.AreEqual(4, result);
        }
        
        [Test]
        public void Multiplicar_2_valores()
        {
            var calc = new Calculate();

            var result = calc.Multiplicar(10, 5);

            Assert.AreEqual(50, result);
        }
    }
}