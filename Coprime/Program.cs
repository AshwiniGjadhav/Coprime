using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coprime
{
    public class Coprime
    {
        public static  bool isCoprime(int a,int b)
        {
            int c = 0;
            for(int i=1;i<=a && i<=b;i++)
            { 
                if(a%i==0 && b%i==0)
                {
                    c++;
                }
            }
            if(c==1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
           // Coprime cp = new Coprime();
            Console.WriteLine("enter the first number");
            int n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int n2=Convert.ToInt32(Console.ReadLine());
            if(Coprime.isCoprime(n1,n2)==true)
            {
                Console.WriteLine("both numbers are coprime");
            }
            else if(Coprime.isCoprime(n1,n2)==false)
            {
                Console.WriteLine("number are not coprime");
            }
        }
    }
}
