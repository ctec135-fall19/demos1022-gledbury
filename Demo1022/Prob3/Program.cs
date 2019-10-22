using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "string from main";

            MyClass mc = new MyClass(s);

            mc.printState();
        }
    }
}
