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
       
        static void Main(string[] args)
        {
            /*CalculateDelegate dlg = CalculateTwoNumber;
            WelcomeDelegate WDlg = WelcomeMessage;
           
            Console.WriteLine(dlg(13,2));
            WDlg("Hoi");
            WDlg("gddgdg"); 
            Console.ReadLine();*/
            FormDelegate formDelegate = new FormDelegate();
            formDelegate.ShowDialog();
        }

      

        
      
     

    }
}
