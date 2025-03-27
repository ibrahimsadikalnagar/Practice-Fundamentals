using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOnly
{
    internal class Program
    {
       delegate int CalculateDelegate(int num1 ,  int num2);
        delegate void WelcomeDelegate(string Name); 

        static void Main(string[] args)
        {
            CalculateDelegate dlg = CalculateTwoNumber;
            WelcomeDelegate WDlg = WelcomeMessage;
           
            Console.WriteLine(dlg(13,2));
            WDlg("Hoi");
            Console.ReadLine();
        }

       public static int  CalculateTwoNumber(int num1 , int num2 )
        {
            return num1 + num2;
        }
        public static void WelcomeMessage(string message)
        {
            Console.WriteLine(message);
        }

        
      
     

    }
}
