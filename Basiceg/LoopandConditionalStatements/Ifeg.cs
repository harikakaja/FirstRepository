using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopandConditionalStatements
{
    class Ifeg
    {
        //greatest of three numbers

     static void Main()

        {
            /*  
                       int num1 = 50, num2 = 40, num3 = 70;

                       if (num1 > num2 && num1 > num3)

                       {

                           Console.WriteLine("Num1 is greater:{0}", num1);

                       }

                       else if (num2 > num1 && num2 > num3)

                       {

                           Console.WriteLine("Num2 is greater:{0}", num2);

                       }

                       else

                       {

                           Console.WriteLine("Num3 is greater:{0}", num3);

                       } */
            //    -------------------------------------------------------------------

            int a, b, c;

            Console.WriteLine("Enter Number 1:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 2:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 3:");
            c = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("---------------------------------------");

            if (a > b && a > c)
            {
                Console.WriteLine("{0} is Greater", a);
           }

            else if (b > a && b > c)
            {
                Console.WriteLine("{0} is Greater", b);

            }
            else if (c > a && c > b)
            {
                Console.WriteLine("{0} is Greater", c);
            }
            else
            {
                Console.WriteLine("All are equal");

            }

            Console.Read();

        }
    }
}
