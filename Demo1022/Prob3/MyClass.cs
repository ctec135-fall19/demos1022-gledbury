using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    class MyClass
    {
        // fields
        private string str;
        private string str2;

        public MyClass(string inStr)
        {
            // composition
            // MyClass owns str. str doesnt exist outside of MyClass
            str = "some string";

            // aggragation
            // str2 refers to object outside of MyClass.
            str2 = inStr;
        }

        public void printState()
        {
            Console.WriteLine("str: {0}", str);
            Console.WriteLine("str2 {0}", str2);
        }
    }
}
