using System;

    class Program:Doacao
    {
        static void Main(string[] args)
        {
            Doacao doacao = new Doacao(1, 1); // Initialize with 0 money

            while (true)
            {
                Console.WriteLine("Selecione o tipo de doação:");
                Console.WriteLine("1. Dinheiro");
                Console.WriteLine("2. Roupas");
                Console.WriteLine("3. Alimentos");
                Console.WriteLine("4. Sair");

                if (!int.TryParse(Console.ReadLine(), out int escolha))
                {
                    Console.WriteLine("Opção inválida. Tente novamente");
                    continue;
                }

                switch (escolha)
                {
                    case 1:
                        doacao.DoarDinheiro(float DN, float II);
                        break;
                    case 2:
                        Console.WriteLine("Saindo...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente");
                        break;
                }
                Console.WriteLine();
            }
        }
    }

   