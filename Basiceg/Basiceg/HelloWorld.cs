using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basiceg
{
    class HelloWorld
    {
        static void Main()

        {
            //to print in console window

            Console.Write("Hello World");

            //To print in a next line

            Console.WriteLine("Hello World");

            Console.WriteLine("-----------------------");

            //print your Name

            string myname = "Harsh ", FatherName = "Raj";

            Console.WriteLine(myname);

            //Concatenation

            //printf("Myname:%c",myname)

            Console.WriteLine("Concatenation");

            Console.WriteLine("MyName:" + myname);

            Console.WriteLine("---------------------");

            //Place holder

            Console.WriteLine("Placeholder");

            Console.WriteLine("MyName:{0}", myname);

            Console.WriteLine("MyName:{0} ||Fathername:{1}", myname, FatherName);

            Console.WriteLine("MyName:{1} {0}", myname, FatherName);

            //to read from console window

            Console.Read();
        }
    }
}
