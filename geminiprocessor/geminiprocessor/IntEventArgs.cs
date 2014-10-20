using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class IntEventArgs : EventArgs
    {
        public int Data { get; set; }
        public IntEventArgs(int data)
        {
            this.Data = data;
        }
    }
}
