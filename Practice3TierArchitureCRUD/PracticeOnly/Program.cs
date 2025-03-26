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
            /* FormDelegate formDelegate = new FormDelegate();
              formDelegate.ShowDialog();*/
            Add(12, 3); 
            Subtract(12, 3);
            Multiply(12, 3);
            Divide(12, 3);
            Console.ReadKey();
        }
        static void Add(int num1 , int num2)
        {
            Console.WriteLine($@"Add {num1} + {num2} =   { num1 + num2} \n" );
          
        }
        static void Subtract(int num1, int num2)
        {
            Console.WriteLine($@"Subtract {num1} - {num2} =    {num1 - num2} ");
          
        }
        static void Multiply(int num1, int num2)
        {
            Console.WriteLine($@"Multiply {num1} * {num2} =    {num1 * num2}");
      
        }
        static void Divide(int num1, int num2)
        {
            Console.WriteLine($@"Divide {num1} / {num2} = {num1 / num2}");
           
        }
     

    }
}
