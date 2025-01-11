using System;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
        Console.WriteLine("Estou pensando em um número entre 1 e 100. Tente adivinhar!");

        // Gera o número secreto
        int numeroSecreto = GerarNumeroSecreto();
        Jogar(numeroSecreto);

        Console.WriteLine("Obrigado por jogar!");
    }

    private static int GerarNumeroSecreto()
    {
        Random random = new Random();
        return random.Next(1, 101); // Número entre 1 e 100
    }

    private static void Jogar(int numeroSecreto)
    {
        bool acertou = false;

        while (!acertou)
        {
            Console.Write("Digite seu palpite: ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int tentativa))
            {
                if (tentativa < numeroSecreto)
                {
                    Console.WriteLine("Muito baixo! Tente novamente.");
                }
                else if (tentativa > numeroSecreto)
                {
                    Console.WriteLine("Muito alto! Tente novamente.");
                }
                else
                {
                    Console.WriteLine($"Parabéns! Você acertou o número {numeroSecreto}.");
                    acertou = true;
                }
            }
            else
            {
                Console.WriteLine("Por favor, digite um número válido.");
            }
        }
    }
}
