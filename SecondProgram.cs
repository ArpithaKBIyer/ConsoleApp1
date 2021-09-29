using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SecondProgram
    {
        static void Main(string[] args)
        {
            Acceptdata();
            Console.ReadLine();
        }

        public static void Acceptdata()
        {
            Console.WriteLine("Enter a  value for i");
            //Convert string to integer
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for j");
            int j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(i);
            Console.WriteLine(j);
        }
    }
}
