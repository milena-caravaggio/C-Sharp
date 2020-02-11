using exercicioPrimos;
using NUnit.Framework;

namespace exerciciosPrimos.test
{
    public class PrimoTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void UmEhPrimo()
        {
            bool result = Program.EhPrimo(1);
            Assert.IsTrue(result);
        }

        [Test]
        public void DoisEhPrimo()
        {
            bool result = Program.EhPrimo(2);
            Assert.IsTrue(result);
        }

        [Test]
        public void TresEhPrimo()
        {
            bool result = Program.EhPrimo(3);
            Assert.IsTrue(result);
        }

        [Test]
        public void QuatroEhPrimo()
        {
            bool result = Program.EhPrimo(4);
            Assert.IsFalse(result);
        }

        [Test]
        public void CincoEhPrimo()
        {
            bool result = Program.EhPrimo(5);
            Assert.IsTrue(result);
        }

        [Test]
        public void SeisEhPrimo()
        {
            bool result = Program.EhPrimo(6);
            Assert.IsFalse(result);
        }

        [Test]
        public void SeteEhPrimo()
        {
            bool result = Program.EhPrimo(7);
            Assert.IsTrue(result);
        }

        [Test]
        public void OitoEhPrimo()
        {
            bool result = Program.EhPrimo(8);
            Assert.IsFalse(result);
        }

        [Test]
        public void NoveEhPrimo()
        {
            bool result = Program.EhPrimo(9);
            Assert.IsFalse(result);
        }

        [Test]
        public void DezEhPrimo()
        {
            bool result = Program.EhPrimo(10);
            Assert.IsFalse(result);
        }

        [Test]
        public void OnzeEhPrimo()
        {
            bool result = Program.EhPrimo(11);
            Assert.IsTrue(result);
        }
    }
}