using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basiceg
{
    class Addition
    {
        static void Main()

        {

            int num1 = 30, num2 = 40, result;

            //dont declare multiple variable with same name and same data type

            /* int num3 = 20;

            int num3 = 40;*/

            //Addition

            result = num1 + num2;

            Console.WriteLine("Addition :{0}", result);

            //subtraction

            result = num1 - num2;

            Console.WriteLine("Subtraction :{0}", result);

            Console.ReadKey();

        }
    }
}
