using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrongprog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,arm=0, sum=0, rem=0;
            Console.WriteLine("Enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            arm  = n;
            while(n>0)
            {
                rem = n % 10;
                sum = sum + (rem*rem*rem);
                n = n / 10;
            }
            if (arm == sum)
            {
                Console.WriteLine("This is Armstrong Number");
            }

            else
            {
                Console.WriteLine("This is Not Armstrong Number");
            }
            Console.ReadLine();   
        }
    }
}
