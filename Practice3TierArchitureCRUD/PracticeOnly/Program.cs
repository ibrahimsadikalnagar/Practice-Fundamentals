using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOnly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ColoumInput = "ID , Name , Age , Address";
            string[] Coloums = ColoumInput.Split(','); 
           foreach (string Coloum in Coloums)
            {
                Console.WriteLine(Coloum.Trim());
            }
            Console.ReadKey();
        }
    }
}
