using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strong_Number
{
    // sum of factorial of digite is equal to itself
    //like 145=1!+4!+5!=145
    class factorial
    {
        public static int fact(int n)
        {
            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                f = f * i;
            }
            return f;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,sum=0;
            Console.WriteLine("Enter the any number");
            n=int.Parse(Console.ReadLine());
            int tmp = n;
            while(n>0)
            {
                int r = n % 10;
                sum = sum + factorial.fact(r);
                n = n / 10;
                
            }
            if(sum==tmp)
            {
                Console.WriteLine("strong number");
            }
            else
            {
                Console.WriteLine("Not strong number");
            }
            Console.ReadKey();
        }
    
    }
}
