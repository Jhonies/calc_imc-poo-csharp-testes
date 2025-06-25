using System;

namespace IMC
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Pressione ESC para sair a qualquer momento"); // Loop para testar sem fechar o console

            while (true)
            {
                var keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.Escape) //Pressionar ESC para sair

                {
                    Console.WriteLine("Tecla ESC pressionada. Encerrando...");
                    break;
                }

                string nome;
                do //Entrada de nome obrigatória
                {
                    Console.WriteLine("Digite seu nome: "); //Entrada de dados:Nome, peso e altura.
                    nome = Console.ReadLine().Trim();

                    if (string.IsNullOrEmpty(nome))

                    {
                        Console.WriteLine("O nome é obrigatório. Tente novamente.");
                    }

                } while (string.IsNullOrEmpty(nome));

                Console.WriteLine("Digite seu peso (kg): ");
                double peso;
                while (!double.TryParse(Console.ReadLine(), out peso) || peso <= 0) //Validação para entrada de peso ser inválida ao ser menor que 0
                {
                    Console.WriteLine("Peso inválido! Digite um valor maior que zero.");
                }


                Console.WriteLine("Digite sua altura (m): ");
                double altura;
                while (!double.TryParse(Console.ReadLine(), out altura) || altura <= 0) //Validação para entrada de altura ser inválida ao ser menor que 0
                {
                    Console.WriteLine("Altura inválida! Digite um valor maior que zero.");
                }

                Pessoa pessoa = new Pessoa(nome, peso, altura); //Cria uma pessoa nova com as informações acima
                double imc = CalculoIMC.Calcular(peso, altura); //Puxa o calculo da classe CalculoIMC
                string classificar = ClassificarIMC.Classificar(imc); //Puxa a classificação do IMC da classe

                Console.WriteLine($"\n{pessoa.Nome}, seu IMC é {imc:F2} e você está classificado como: {classificar}"); //Dados finais do usuário
            }
        }
    }
}
