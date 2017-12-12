using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class HelloMsg : IPrintable
    {
        public void print(string output)
        {
            Console.WriteLine(output);
        }
    }
}
