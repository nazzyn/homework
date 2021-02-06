using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{

    static void Main(string[] args)
    {
        string a, b;
        int H, R;
        double V, p = 3.14;
        Console.Write("Введите высоту конуса ");
        a = Console.ReadLine();
        H = Convert.ToInt32(a);
        Console.Write("Введите радиус основы конуса ");
        b = Console.ReadLine();
        R = Convert.ToInt32(b);

        V = (H / 3) * p * (R * R);

        Console.WriteLine("Объем конуса = " + V);
        Console.ReadKey();
    }
}