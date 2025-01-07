using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    internal class CurrentAccount: Account 
    {
        double InterestRate
        {
            get
            {
                return 0.03;
            }

        }
        public override void CalculateIntrest()
        {
            throw new NotImplementedException();
        }
    }
}
