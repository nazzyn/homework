using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{

    static void Main(string[] args)
    { 
        string a, b, c;
        int a1, b1, c1;
        Console.Write("Уведiть першу цифру ");
        a = Console.ReadLine();
        a1 = Convert.ToInt32(a);
        Console.Write("Уведiть другу цифру ");
        b = Console.ReadLine();
        b1 = Convert.ToInt32(b);
        Console.Write("Уведiть третю цифру ");
        c = Console.ReadLine();
        c1 = Convert.ToInt32(b);
        if (a == b || a == c || b == c)
        {
            Console.WriteLine("Серед трьох даних цiлих чисел є хоч би одна пара спiвпадаючих");
        }
        else
        {
            Console.WriteLine("Серед трьох даних цiлих чисел не має хоч би однiєї пари спiвпадаючих");
        }
        Console.ReadKey();
    }
}
