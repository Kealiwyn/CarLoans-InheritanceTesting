using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLoans
{
    class CarLoan : Loan
    {
        private const int EARLIEST_YEAR = 2006;
        private const int LOWEST_INVALID_NUM = 1000;
        private int year;


        public string Make { get; set; }
        public int Year { 
            get 
            {
                return year;
            }
            set 
            {
                if (value < EARLIEST_YEAR)
                {
                    year = value;
                    loanAmount = 0;
                }
                else
                    year = value;
            }
        }
        public new int LoanNumber
        {
            get { return base.LoanNumber; }
            set
            {
                if (value < LOWEST_INVALID_NUM)
                {
                    base.LoanNumber = value;
                }
                else
                    base.LoanNumber = value % LOWEST_INVALID_NUM;
            }
        }
        public CarLoan(int loanNumber,
            string lastName,
            double loanAmount,
            string make,
            int year)
        {
            LoanNumber = loanNumber;
            LastName = lastName;
            LoanAmount = loanAmount;
            Make = make;
            Year = year;
        }

        public override string ToString()
        {
            return $"{base.ToString()} -- Make: {Make} -- Year: {Year}";
        }
    }
}
