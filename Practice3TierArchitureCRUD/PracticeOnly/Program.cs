using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeOnly
{
     delegate string Del(string G); 
    
   
    internal class Program
    {
      
       
        static void Main(string[] args)
        {

            Del trsnlator = new Del(GreatingDutch);
            string result = trsnlator.Invoke("Hello ales "); 
            Console.WriteLine(result);
            Console.ReadKey();
       
        }
       
        public static  string GreatingDutch(string GreatingDutch)
        {
            return GreatingDutch; 
        }
        private string GreatingEnglish(string GreatingEnglish)
        {
            return "Hello";
        }

      

        
      
     

    }
}
