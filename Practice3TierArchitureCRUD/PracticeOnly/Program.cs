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

            

                FormDelegate1 fD = new FormDelegate1();
                 fD.ShowDialog();
            

        }
 

    }
}
