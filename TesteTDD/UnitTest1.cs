using DesafioCodigoTDD;
using System;

namespace TesteTDD
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1,2,3)]
        [InlineData(4, 5, 9)]
        public void TesteSomar(int val1, int val2, int esperado)
        {
            //arrange
            Calculadora calc = new Calculadora();

            //act
            int result = calc.soma(val1, val2);

            //assert
            Assert.Equal(esperado, result);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int val1, int val2, int esperado)
        {
            //arrange
            Calculadora calc = new Calculadora();

            //act
            int result = calc.multiplicar(val1, val2);

            //assert
            Assert.Equal(esperado, result);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TesteDividir(int val1, int val2, int esperado)
        {
            //arrange
            Calculadora calc = new Calculadora();

            //act
            int result = calc.dividir(val1, val2);

            //assert
            Assert.Equal(esperado, result);
        }

        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(6, 5, 1)]
        public void TesteDSubtrair(int val1, int val2, int esperado)
        {
            //arrange
            Calculadora calc = new Calculadora();

            //act
            int result = calc.subtrair(val1, val2);

            //assert
            Assert.Equal(esperado, result);
        }

        [Fact]
        public void TesteDivisaoPorZero()
        {
            //arrange
            Calculadora calc = new Calculadora();
            DivideByZeroException ex = new DivideByZeroException();


            //assert
            Assert.Throws<DivideByZeroException>(
                () => calc.dividir(3, 0)
            );
        }

        [Fact]
        public void TesteHistorico()
        {
            //arrange
            Calculadora calc = new Calculadora();

            //act
            calc.subtrair(1, 0);
            calc.dividir(6, 2);
            calc.multiplicar(2, 3);
            calc.soma(2, 1);
            var lista = calc.historico();

            //assert
            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count());
        }
    }
}