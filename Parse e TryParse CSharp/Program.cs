using System;

namespace Parse_e_TryParse_CSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            bool funcionou = int.TryParse("544", out int valor);

            Console.WriteLine(funcionou);
            Console.WriteLine(valor);
            //resultado = true, 544

            bool funcionou2 = int.TryParse("chute", out int valor2);
            Console.WriteLine(funcionou2);
            Console.WriteLine(valor2);
            //resultado = false, 0

        }
    }
}
