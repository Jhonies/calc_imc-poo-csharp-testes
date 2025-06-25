using IMC;
using Xunit;

namespace xUnit_Test
{
    public class xUnit_test
    {
        // TESTE 1 - Calculo de IMC
        [Fact]
        public void Teste_IMC()
        {
            double peso = 80;
            double altura = 1.60;
            double imcEsperado = 31.25;

            double imcCalculado = CalculoIMC.Calcular(peso, altura);

            Assert.Equal(imcEsperado, imcCalculado, 2); // precisão de 2 casas decimais
        }

        // TESTE 2 - Classificação de IMC
        [Theory]
        [InlineData(50, 1.70, "Abaixo do peso")]
        [InlineData(65, 1.70, "Peso normal")]
        [InlineData(85, 1.78, "Sobrepeso")]
        [InlineData(105, 1.82, "Obesidade grau 1")]
        [InlineData(120, 1.83, "Obesidade grau 2")]
        [InlineData(120, 1.70, "Obesidade grau 3 (mórbida)")]
        public void Teste_Categoria_IMC(double peso, double altura, string categoriaEsperada)
        {
            double imc = CalculoIMC.Calcular(peso, altura);
            string categoriaObtida = ClassificarIMC.Classificar(imc);

            Assert.Equal(categoriaEsperada, categoriaObtida);
        }

        // TESTE 3 - Entradas Inválidas 
        [Theory]
        [InlineData(0, 1.70, "Peso inválido!")]
        [InlineData(-100, 1.70, "Peso inválido!")]
        [InlineData(65, 0, "Altura inválida!")]
        [InlineData(65, -1.60, "Altura inválida!")]
        public void Teste_Valores_Invalidos(double peso, double altura, string mensagemEsperada)
        {
            var ex = Assert.Throws<ArgumentException>(() => CalculoIMC.Calcular(peso, altura));
            Assert.Equal(mensagemEsperada, ex.Message);
        }
    }
}