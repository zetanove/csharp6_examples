using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationCS6
{
    class DeclarationExpression
    {
        static void Main()
        {
            if(int.TryParse("123", out int result))
            {
                Console.WriteLine(result);
            }
        }
    }
}
