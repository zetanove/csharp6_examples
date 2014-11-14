using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationCS6
{
    class IndexInitializers
    {
        static void Main()
        {

            //old mode
            var numbers =
                new Dictionary<int, string>
                {
                    { 7 , "seven" },
                    { 9 , "nine" },
                    { 13 , "thirteen" },
                };

            var numbers2 =
                new Dictionary<int, string>
                {
                    [7] = "seven",
                    [9] = "nine",
                    [13] = "thirteen"
                };


            foreach (int k in numbers2.Keys)
            {
                Console.WriteLine("{0}: {1}", k, numbers[k]);
            }

            var strings = new Dictionary<string, Person>
            {
                ["antonio"] = new Person("Antonio"),
                ["pippo"] = new Person("Pippo"),
            };

            var persona = new Person("antonio")
            {
                [0] = "1628692",
                [3] = "0299992",
            };

            for (int i = 0; i< persona.numbers.Length; i++)
            {
                Console.WriteLine("{0}: {1}", i, persona[i]);
            }

        }
    }

    public class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public string[] numbers = new string[5];
        
        public string this[int index]
        {
            get
            {
                return
                        numbers[index];
            }
            set
            {
                numbers[index] = value;
            }
        }        
    }
}
