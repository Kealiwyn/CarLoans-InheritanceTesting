using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLoans
{
    class Program
    {
        static void Main(string[] args)
        {
            Loan aLoan = new Loan(2239, "Mitchell", 1000.00);
            Console.WriteLine(aLoan.ToString());

            CarLoan aCarLoan = new CarLoan(3358, "Jansen", 20000.00, "Ford", 2005);
            Console.WriteLine(aCarLoan.ToString());

            Console.ReadKey();
        }
    }
}
