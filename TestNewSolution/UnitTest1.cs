using NewSolution;
namespace TestNewSolution
  
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1,2,3)]
        [InlineData(4, 5, 9)]
        public void TestSomar(int val1, int val2, int result)
        {
            Calculadora calc = new Calculadora();
            int resultado = calc.somar(val1, val2);
            Assert.Equal(result, resultado);
        }

        [Theory]
        [InlineData(2, 2,0)]
        [InlineData(5, 3,2)]
        public void TestSubtrair(int val1, int val2, int result)
        {
            Calculadora calc = new Calculadora();
            int resultado = calc.subtrair(val1, val2);
            Assert.Equal(result, resultado);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TestMultiplicar(int val1, int val2, int result)
        {
            Calculadora calc = new Calculadora();
            int resultado = calc.multiplicar(val1, val2);
            Assert.Equal(result, resultado);
        }

        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(40, 5, 8)]
        public void TestDividir(int val1, int val2, int result)
        {
            Calculadora calc = new Calculadora();
            int resultado = calc.dividir(val1, val2);
            Assert.Equal(result, resultado);
        }

        [Fact]
        public void TestarDividirPorZero()
        {
            Calculadora calc = new Calculadora();
            Assert.Throws<DivideByZeroException>(() => calc.dividir(1, 0));
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = new Calculadora();
            calc.somar(1, 2);
            calc.somar(1, 3);
            calc.somar(1, 4);
            calc.somar(1,5);

            var lista = calc.historico();
            Assert.NotEmpty(lista);
            Assert.Equal(3,lista.Count);
           
        }
    }
}