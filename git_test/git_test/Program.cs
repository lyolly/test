using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_test
{
    class Program
    {
        private static void Foo()
        {
            Console.Out.WriteLine("Wywolanie funkcji");
        }

        static void Main(string[] args)
        {
            Foo();
            Console.Out.WriteLine("Nowa zmiana");
        }
    }
}
