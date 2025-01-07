using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class SavingsAccount : Account
    {
        double InterestRate 
        {
            get
            {
                return 0.06;
            }
        
        }
        public override void CalculateIntrest()
        {
            
        }
    }
}
