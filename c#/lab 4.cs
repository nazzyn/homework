using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    static void Main(string[] args)
    {
        string n1;
        int N, max = 0;
        Console.Write("Введите размер масиива");
        n1 = Console.ReadLine();
        N = Convert.ToInt32(n1);
        string[] A = new string[N];

        for (int i = 0; i < N; i++)
        {
            Console.Write("Вветиде " + "[ " + i + " ]" + " элемент ");
            A[i] = Console.ReadLine();
        }
        Console.WriteLine("Ваш массив ");
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine(A[i]);
        }
        for (int i = 0; i < N; i++)
        {
            if (Convert.ToInt32(A[i]) > max)
            {
                max = Convert.ToInt32(A[i]);
            }
        }
        for (int i = 0; i < N; i++)
        {
            if (Convert.ToInt32(A[i]) < 0)
            {
                A[i] = Convert.ToString(max);
            }
        }
        Console.WriteLine("Ваш массив после замены отрицательных чисел на максимальное число ");
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine(A[i]);
        }

        Console.ReadKey();
    }
}
