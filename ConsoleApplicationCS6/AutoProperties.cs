using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationCS6
{
    class ProgramAutoProp
    {
        static void Main()
        {
            Persona2 p = new Persona2();
            Console.WriteLine("{0} {1}", p.Nome, p.Cognome);

            Persona3 p3 = new Persona3();
            Console.WriteLine("{0} {1}", p3.Nome, p3.Cognome);
        }
    }


    public class Persona2
    {
        public string Nome { get; set; } = "Antonio";
        public string Cognome { get; set; } = "Pelleriti";
    }

    public class Persona3
    {
        public string Nome { get; } = "Antonio";
        public string Cognome { get;  } = "Pelleriti";
    }

    //non funziona in CTP, dovrebbe in C# 6 final
    //public class Persona
    //{
    //    public string Nome { get; }
    //    public Persona(string nome)
    //    {
    //        Nome = nome; //Errore in C# 5
    //    }
    //}

}
