using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    internal class CurrentAccount: Account 
    {
        decimal InterestRate
        {
            get
            {
                return 0.03m;
            }

        }
        public override void CalculateIntrest()
        {
            decimal interest; 
            DateTime allowedDate = DateTime.Now.AddYears(-1);
            if(InteresstDate <= allowedDate)
            {
                interest = Balance * InterestRate;
                Balance = Balance + interest;
                InteresstDate = DateTime.Now;
            }
        }
    }
}
