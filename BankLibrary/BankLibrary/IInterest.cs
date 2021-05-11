using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    interface IInterest
    {
        double CalculateInterest();     // methods are public and abstract by default of interface
    }
}
