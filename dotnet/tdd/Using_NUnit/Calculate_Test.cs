using NUnit.Framework;

namespace Using_NUnit
{
    [TestFixture]
    public class Calculate_Test
    {
        [Test]
        public void Somar_2_valor()
        {
            var calc = new Calculate();

            var result = calc.Somar(2, 2);

            Assert.AreEqual(4, result);
        }
    }
}