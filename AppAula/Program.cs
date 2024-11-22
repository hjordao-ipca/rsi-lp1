using System;
using System.Collections.Generic;

namespace AppAula
{
    class Program
    {

        static void Main(string[] args)
        {
            // Criar uma (instância) Lista de strings para armazenar o
            // que o utilizador vai introduzir (linha a linha)
            List<string> inputSentences = new List<string>();
            // Verifica se o array strings args != vazio
            if (args.Length > 0) {
                // Verificar se consegue converter em inteiro e se conseguir
                // o valor inteiro será atribuído a variável de saída number 
                bool isInteger = int.TryParse(args[0], out int number);
                // Se for inteiro entra no if
                if (isInteger) {
                    Console.WriteLine($"Introduza {number} linhas...");
                    // Percorre o número de vezes passado por argumento (args[0])
                    for (int i = 0; i < number; i++) {
                        Console.WriteLine($"Escreva a n-esima {i + 1} frase: ");
                        // Recebe o que o utilizador introduz (linha a linha)
                        // ? - significa que pode ser null (vazio)
                        string? recvArgs = Console.ReadLine();
                        // Verificar se for vazio não adiciona
                        if (recvArgs != null) {   // Adicionar ao final da lista de frases
                            inputSentences.Add(recvArgs);
                        } else {
                            Console.WriteLine("Enviou uma posição vazia!");
                        }
                    }

                    // Percorrer a Lista de frases (item a item)
                    foreach (var item in inputSentences) {
                        Console.WriteLine(item);
                    }
                } else {
                    Console.WriteLine("Usage: <numTimes> needs to be an Integer.");
                }
            } else {
                Console.WriteLine("Usage: dotnet run <numTimes>");
            }
        }
    }
}