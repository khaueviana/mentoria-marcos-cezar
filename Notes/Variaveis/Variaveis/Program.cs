using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;

            x = 7;
            y = x + 3;
            Console.WriteLine(y);
            Console.ReadLine();
            */

            Console.WriteLine("Qual é o seu nome?");
            Console.Write("Digite o seu primeiro nome: ");
            string meuPrimeiroNome;
            meuPrimeiroNome = Console.ReadLine();

            //string meuSobrenome;
            //Console.Write("Digite seu sobrenome: ");
            //meuSobrenome = Console.ReadLine();


            Console.Write("Digite seu sobrenome: ");
            string meuSobrenome = Console.ReadLine();


            Console.WriteLine("Oi. " + meuPrimeiroNome + " "+ meuSobrenome);
            Console.ReadLine();
        }
    }
}
