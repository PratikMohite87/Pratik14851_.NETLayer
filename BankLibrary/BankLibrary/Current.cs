using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class Current : Bank
    {
        public sealed override void Withdraw(int amount)        // you cannot further override this method in subclass becoz od sealed keyword.
        {
            throw new NotImplementedException();
        }
    }
}
