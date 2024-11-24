namespace TestProject1
{
    public class Tests
    {
        private Aritmetica aritmetica;

        [SetUp]
        public void Setup()
        {
            aritmetica = new Aritmetica();
        }

        [Test]
        public void TestSuma()
        {
            int a = 1;
            int b = 2;
            int resultado = aritmetica.sumar(a, b);
            Assert.AreEqual(3, resultado);  
        }

        [Test]
        public void TestResta()
        {
            int a = 5;
            int b = 3;
            int resultado = aritmetica.restar(a, b);
            Assert.AreEqual(2, resultado);
        }

        [Test]
        public void TestMultiplicacion()
        {
            int a = 2;
            int b = 3;
            int resultado = aritmetica.multiplicar(a, b);
            Assert.AreEqual(6, resultado);
        }

        [Test]
        public void TestDivision()
        {
            int a = 6;
            int b = 2;
            double resultado = aritmetica.dividir(a, b);
            Assert.AreEqual(3, resultado);
        }

        [Test]
        public void TestDivisionPorCero()
        {
            int a = 6;
            int b = 0;
            Assert.Throws<DivideByZeroException>(() => aritmetica.dividir(a, b));
        }
    }
}
