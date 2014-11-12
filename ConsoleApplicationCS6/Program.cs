using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//cs 6 static members using
using System.Console;

namespace ConsoleApplicationCS6
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello world");
            Persona p = new Persona("antonio");
            Persona p2 = null;

            //null prop
            string s = p2?.Address?.ToString();


            

            //declaration expressions
            if (long.TryParse("123", out long id))
            {
                Console.WriteLine(id);
            }
        }
    }

    class Persona(string n)
    {
        private string nome = n;

        public Guid ID { get; set; }=Guid.NewGuid();

        public string Address;

        public string Nome { get; set; }=n;
    }
}
