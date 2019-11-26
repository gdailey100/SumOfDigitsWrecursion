using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumof_DigitswRecursion
{
    class Program
    {
        public static void Main()
        {
            int num, results;
            pro pg = new pro();
            Console.WriteLine("Enter a number: ");
            num = Int32.Parse(Console.ReadLine());
            results =pg.sum(num);
            Console.WriteLine("The sum of the digits in {0} is {1}", num, results);
            Console.ReadLine();
        }
    }
}

class pro
{
    public int sum(int num)
    {
        if (num != 0)
        {
            return (num % 10 + sum(num / 10));
        }
        else
        {
            return 0;
        }
    }
}