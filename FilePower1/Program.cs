using System;
using System.Collections.Generic;
using System.IO;

namespace FilePower1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Por favor, forneça o nome do arquivo como argumento.");
                return;
            }

            string fileName = args[0];
            Queue<string> inputQueue = new Queue<string>();

            Console.WriteLine("Digite as strings (pressione Enter para cada uma):");

            while (true)
            {
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                    break;

                inputQueue.Enqueue(input);
            }

            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    foreach (string str in inputQueue)
                    {
                        writer.WriteLine(str);
                    }
                }

                Console.WriteLine($"As strings foram salvas com sucesso no arquivo '{fileName}'.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao escrever no arquivo: {ex.Message}");
            }
        }
    }
}
