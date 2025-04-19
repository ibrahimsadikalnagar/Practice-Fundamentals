using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOnly
{
    public class AdditionEventArgs1:EventArgs
    {
        public int Result { get;}
        public AdditionEventArgs1(int result)
        {
            Result = result;
        }
    }
}
