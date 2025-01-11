using System;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
        Console.WriteLine("Advinhe o número entre 1 e 100!");

        int numeroSecreto = GerarNumeroSecreto();
        Jogar(numeroSecreto);

        Console.WriteLine("Valeu por jogar!");
    }

    private static int GerarNumeroSecreto()
    {
        Random random = new Random();
        return random.Next(1, 101);
    }

    private static void Jogar(int numeroSecreto)
    {
        bool acertou = false;
        int tentativas = 0;

        while (!acertou)
        {
            Console.Write("Digite qual número você imagina: ");
            string? entrada = Console.ReadLine();
            tentativas++; //adcionando o contador de tentativas

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
                    Console.WriteLine($"Parabéns! Você acertou o número {numeroSecreto} em {tentativas} tentativas.");
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
