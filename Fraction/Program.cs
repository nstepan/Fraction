using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nik;
using static System.Console;

namespace Nik
{
    class Program
    {
        static void Main(string[] args)
        {
            var f1 = new Fraction(1, 2);
            var f2 = new Fraction(3, 4);
            var sum = f1 + f2;
            WriteLine("Sum = " + sum);
        }
    }
}
