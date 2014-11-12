using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationCS6
{
    class ExceptionFilter
    {
        static void Main()
        {
            //exception filters
            try
            {
                throw new Exception("Me");
            }
            catch (Exception ex) if (ex.Message == "You")
            {
                // this one will not execute.
            }
            catch (Exception ex) if (ex.Message == "Me")
            {
                // this one will execute
                Console.Write(ex.Message);
            }
        }


    }
}
