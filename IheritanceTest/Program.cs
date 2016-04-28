using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IheritanceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate Father List which is going to hold the Daughter and Son objects
            List<Father> myList = new List<Father>();

            //Instatiate Son (derived from Father) object and add values
            Son theSon = new Son();
            theSon.HasADick = true;
            theSon.Age = 20;
            theSon.Name = "Luke";

            //Instatiate Daughter (derived from Father) object and add values
            Daughter theDaughter = new Daughter();
            theDaughter.HasAPussy = true;
            theDaughter.Name = "Leia";
            theDaughter.Age = 19;

            //Add Son and Daughter objects to the baseclass List<Father>
            myList.Add(theSon);
            myList.Add(theDaughter);

            //Print objects in the Father list
            Console.WriteLine("*************iteration start***********");
            foreach (var item in myList)
            {
                if (item is Son)
                {
                    Son tempSon = item as Son;
                    Console.WriteLine("Name: {0}", item.Name);
                    Console.WriteLine("Age: {0}", item.Age);
                    Console.WriteLine("Has a dick: {0}", tempSon.HasADick);

                }
                else if (item is Daughter)
                {
                    Daughter tempDaughter = item as Daughter;
                    Console.WriteLine("Name: {0}", item.Name);
                    Console.WriteLine("Age: {0}", item.Age);
                    Console.WriteLine("Has a pussy: {0}", tempDaughter.HasAPussy);
                }
                if (!myList.LastIndexOf(item).Equals(myList.Count - 1))
                {
                    Console.WriteLine("     /^ ^          ( o Y o)                   ");
                    Console.WriteLine("    / . .)          )    (                   ");
                    Console.WriteLine("*******************(   *  )*******************");
                    Console.WriteLine("      OMG..!        \\  Y /                   ");
                    Console.WriteLine("                     \\/ /                   ");
                }
            }
            Console.WriteLine("*************iteration end*************");

        }

        public class Father
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public class Son : Father
        {
            public bool HasADick { get; set; }
        }

        public class Daughter : Father
        {
            public bool HasAPussy { get; set; }
        }
    }
}
