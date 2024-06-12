using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_check
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = MyLibrary.MyLibrary.Add(5, 3);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

