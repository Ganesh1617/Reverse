using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    internal class Program
    {
        public void reverse()
        {
            int n = 123, r = 0;
            while (n > 0)
            {
                r = (n % 10);
                n /= 10;
                Console.Write(r);
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.reverse();
            Console.ReadLine();
        }
    }
}
