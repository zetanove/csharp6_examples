using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationCS6
{
    class StringInterpolation
    {
        static void Main()
        {
            string nome = "antonio";
            string cognome = "pelleriti";

            Console.WriteLine("{0} {1}", nome, cognome);

            string str="{nome} {cognome}";
            Console.WriteLine(str);

        }
    }
}
