using System.Data;
using IMC;

namespace MSTest_Test
{
    [TestClass]
    public class MSTest_test
    {
        // TESTE 1 - Calculo de IMC
        [TestMethod]
        public void Teste_Calculo_IMC()
        {
            double peso = 80;
            double altura = 1.60;
            double imc_previsto = 31.25;

            double imc_calculado = CalculoIMC.Calcular(peso, altura);

            Assert.AreEqual(imc_previsto, imc_calculado, 0.001);
        }
        // TESTE 2 - Classificação de IMC
        [DataTestMethod]
        [DataRow(50, 1.70, "Abaixo do peso")]
        [DataRow(65, 1.70, "Peso normal")]
        [DataRow(85, 1.78, "Sobrepeso")]
        [DataRow(105, 1.82, "Obesidade grau 1")]
        [DataRow(120, 1.83, "Obesidade grau 2")]
        [DataRow(120, 1.70, "Obesidade grau 3 (mórbida)")]

        [TestMethod]
        public void Teste_Categoria_IMC(double peso, double altura, string categoria_esperada)
        {
            double imc_calculado = CalculoIMC.Calcular(peso, altura);
            string categoria_obtida = ClassificarIMC.Classificar(imc_calculado);

            Assert.AreEqual(categoria_esperada, categoria_obtida);
        }
        // TESTE 3 - Entradas Inválidas 
        [DataTestMethod]
        [DataRow(0, 1.70, "Peso inválido!")]
        [DataRow(-100, 1.70, "Peso inválido!")]
        [DataRow(65, 0, "Altura inválida!")]
        [DataRow(65, -1.60, "Altura inválida!")]
        public void Teste_Valores_Invalidos(double peso, double altura, string mensagem_esperada)
        {
            try
            {
                // Tenta calcular com valores inválidos
                CalculoIMC.Calcular(peso, altura);

                // Se não lançar exceção, o teste falha
                Assert.Fail("Era esperada uma exceção do tipo ArgumentException.");
            }
            catch (ArgumentException ex)
            {
                // Verifica se a mensagem da exceção está correta
                Assert.AreEqual(mensagem_esperada, ex.Message);
            }
        }
    }
}
