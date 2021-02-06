using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    static void Main(string[] args)
    {
        double u = 0;
        double S = 0;
        int a = 0;
        double x;
        string b;
        Console.WriteLine("Введите значение ");

        do
        {
            b = Console.ReadLine();
            x = Convert.ToDouble(b);
            if (a > x)
            {
                Console.WriteLine("Введите другое значение ");
            }
        } while (a > x);

        for (int i = 0; i <= x; i++)
        {
            u += (Math.Pow(i, 2) + Math.Pow(-1, i - 1) * 2 * i - 1) / (Math.Pow(i, 2) + 8);
            S += u;
            Console.WriteLine("u" + i + "=" + u);
            u = 0;
        }
        Console.WriteLine("Сума = " + S);
        Console.ReadKey();
    }
}