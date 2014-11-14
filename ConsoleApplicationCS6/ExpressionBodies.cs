using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationCS6
{
    class ExpressionBodies
    {
        static void Main()
        {
            Person p = new Person() { Nome = "Antonio", Cognome = "Pelleriti" };
            Console.WriteLine(p.Completo);

            p.Print("ing.");

            Console.WriteLine((string)p);
        }


        public class Person
        {
            public string Nome { get; set; }
            public string Cognome { get; set; }

            public string Completo => String.Format("{0} {1}", Nome, Cognome);

            public void Print(string title) => Console.WriteLine(title+" "+Nome + " " + Cognome);

            public static implicit operator string (Person p)  => p.Nome + " " + p.Cognome;
        }
    }
}
