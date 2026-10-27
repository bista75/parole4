using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parole4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase;
            do
            {
                Console.WriteLine("Inserire una parola");
                frase = Console.ReadLine();
                Console.WriteLine("Riprova");

            } while (frase == "");

            string[] parole = frase.Split(' ');
            Console.WriteLine("Numero di parole: " + parole.Length);

        }
    }
}
