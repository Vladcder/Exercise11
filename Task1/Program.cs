using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Линейное уравнение имеет вид kx+b=0");
            Console.Write("Введите коэффициент k: ");
            int k=Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите коэффициент b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            var equation=new LinearEquation(k, b);
            Console.WriteLine($"Корень уравнения {k}x+{b}=0 равен "+ equation.Root());
            Console.ReadKey();

        }
    }



    public struct LinearEquation
    {
        int k;
        int b;

        public LinearEquation(int k, int b)
        {
            this.k = k;
            this.b = b;
        }


        public double Root()
        {
            return (double)-b / k;
        }
    }
}
