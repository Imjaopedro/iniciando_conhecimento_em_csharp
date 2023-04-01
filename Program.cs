using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int maior = 0;
            int menor = 0;
            int i = 0;
            
            while (i <= 10){
                Console.Write("Entre com um número: ");
                num = int.Parse(Console.ReadLine());
                i+=1;

                if (maior < num){
                    maior = num;
                }
                else {
                    menor = num;
                }
                
            }
        Console.WriteLine($"O maior numero foi {maior} e o menor foi {menor}");
        }
    }
}
