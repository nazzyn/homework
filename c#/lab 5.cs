using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            WMatrix min = new WMatrix();
            var mat = min.CreatMatrix();
            WMatrix max = new WMatrix();
            max.MatrixMin(mat);
            max.SortMatrix(mat);
        }
    }
}
