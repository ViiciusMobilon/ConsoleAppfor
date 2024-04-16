using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppfor
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            double valor = 0;
            double vf = 0;
            double vp = 0;
            double n = 0;
            string s;
            do
            {
                Console.WriteLine("Digite o valor gasto na compra");
                valor = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a descrição da compra:");
                Console.ReadLine();
                
                Console.WriteLine("Se eseja continuar digite (s)");
                s = Console.ReadLine().ToLower();

                vf = valor + vf;

            }
            while  (s == "s");
            Console.WriteLine("Digite o numero de moradores:");
            n = double.Parse(Console.ReadLine());

            vp = vf / n;

            Console.WriteLine("O valor total da compra deu:" + vf + " e o valor por morador é :" + vp);
            Console.ReadKey();
        }
    }
}
