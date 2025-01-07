using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    abstract class Account
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public DateTime InteresstDate { get; set; }
        private void Deposit()
        {

        }
        private void WithDraw()
        {

        }
        public abstract void CalculateIntrest();

        public override string ToString()
        {
            return $"{AccountNumber} - {LastName}, {FirstName}";
        }
    }
}
