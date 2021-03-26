using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLoans
{
    class Loan
    {
        public const double MINIMUM_LOAN = 5000;
        protected double loanAmount;

        public int LoanNumber { get; set; }
        public string LastName { get; set; }
        public double LoanAmount {
            get 
            {
                return loanAmount;
            }
            set 
            {
                if (value < MINIMUM_LOAN)
                    loanAmount = MINIMUM_LOAN;
                else
                loanAmount = value;
            }
        }

        public Loan() { }
        public Loan(int loanNumber, string lastName, double loanAmount)
        {
            LoanNumber = loanNumber;
            LastName = lastName;
            LoanAmount = loanAmount;
        }

        public override string ToString()
        {
            return $"-- Loan number: {LoanNumber} -- Last name: {LastName} -- Loan amount: {LoanAmount:c}";
        }
    }
}
