using NUnit.Framework;

namespace Using_NUnit
{
    [TestFixture]
    public class NumerosRomanos_Test
    {
        [Test]
        public void EntenderOsSimbolos()
        {
            // Arrange
            NumerosRomanos romanos = new NumerosRomanos();
            
            // Act
            bool verificado = romanos.Converter("V");
            
            // Assert
            Assert.IsTrue(verificado);
        }        
    }
}