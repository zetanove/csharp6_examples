using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationCS6
{
    public class NameOf
    {
        static void Main()
        {
            int x = 0;
            Console.WriteLine("{0}={1}", nameof(x), x);
        }
    }
}
