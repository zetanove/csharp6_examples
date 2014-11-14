using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Console;

namespace ConsoleApplicationCS6
{
    class Program
    {
        public static async Task<bool> Log(Exception ex)
        {
            Console.WriteLine(ex.Message);


            try
            {
                throw new Exception("");
            }
            catch
            {
                await Task.Delay(1000);
            }

            return false;
        }

        static void Main(string[] args)
        {
            Persona p = new Persona();
            Log(new Exception());

            WriteLine(p?.myaddress?.Indirizzo);

            p.myaddress = new Address() ;
            WriteLine(p?.myaddress?.Indirizzo);

            int x=0;

        }


    }
    class Persona
    {
        public string Nome { get; set; } ="Antonio";

        public Address myaddress { get; set; }
    }

    class Address
    {
        public string Indirizzo  => "via di qui";
    }

}
