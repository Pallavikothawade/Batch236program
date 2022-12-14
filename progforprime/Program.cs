using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progforprime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0, a = 0;
            Console.WriteLine("Enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    a++;
                }

            }
            if (a == 2)
            {
                Console.WriteLine("This is a prime no");
            }
            else
            {
                Console.WriteLine("This is not prime no");
            }
            Addition obj = new Addition();
            obj.add();
            Console.ReadLine();
        }
    }
}
