using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InBuiltDelegates
{
    class Class1
    {
        private int number;
        public Action Ac { set; get; }

        public int Number
        {
            set 
            {
                if (value != 0)
                    this.number = value;
                else
                    Ac();
            }
        }
    }
}
