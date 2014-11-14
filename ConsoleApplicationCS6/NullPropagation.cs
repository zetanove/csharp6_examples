using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationCS6
{
    class NullPropagation
    {
        static void Main()
        {
            string str = null;
            int? len = str?.Length;
            char? primo = str?[0];
            Console.WriteLine(len);
            Console.WriteLine(primo);

            Person p = null;

            string city = p?.MyAddress?.City?.ToLower();
        }

        public class Person {
            public Address MyAddress { get; set; }
        }

        public class Address {
            public string City { get; set; }
        }
    }
}
