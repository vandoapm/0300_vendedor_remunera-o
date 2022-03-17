using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0300_vendedor_remuneração
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Exibir o Vendedor, salário fixo e slario + comissão");
            Console.WriteLine();

            Console.Write("Nome do vendedor: ");
            string n = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Salário fixo: ");
            float s = float.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Vendas do mês: ");
            float v = float.Parse(Console.ReadLine());
            float r = v * 0.2f;

            Console.WriteLine();

            Console.Write("Vendedor: ");
            Console.Write(n);
            Console.Write(" | Salário fixo: ");
            Console.Write(s);
            Console.Write(" | Remuneração Total: ");
            Console.Write(s + r);

            Console.ReadLine();


        }
    }
}
