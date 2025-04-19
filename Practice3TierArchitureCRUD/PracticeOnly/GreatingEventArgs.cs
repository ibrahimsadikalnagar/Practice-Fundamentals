using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOnly
{
    public class GreatingEventArgs:EventArgs
    {
        public string Greating {  get; }
        public GreatingEventArgs(string greating) 
        { 
            this.Greating = greating;
        }

    }
}
