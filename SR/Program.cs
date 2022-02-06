using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 3.1
{
    internal class Program
    {
        //создание метода вычисления процента
        static void AddPersent(double a, out double b)
        {
            b = 0;
            if (a < 100) b = a + a / 100 * 5;
            if (a >= 100 && a < 200) b = a + a / 100 * 7;
            if (a >= 200) b = a + a / 100 * 10;
            Console.WriteLine($"Сумма с начисленными процентами = {b:0.0}");
        }
        static void Main(string[] args)
        {
            Console.Write("Введите сумму вклада ");
            double a =Convert.ToDouble(Console.ReadLine());
            //вызов созданного методаа
            AddPersent(a, out double b);
            Console.ReadKey();
        }
    }
}
