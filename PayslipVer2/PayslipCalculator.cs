using System;
using System.Collections.Generic;

namespace PayslipVer2
{
    public class PayslipCalculator
    {
        private const int AnnualMonths = 12;

        public int CalculateGrossIncome(double annualSalary)
        {
            var sum = (int) Math.Round(annualSalary / AnnualMonths);
            return sum;
        }

        public int CalculateIncomeTax(int taxOnIncome, int annualSalary, int lowerTaxableIncomeBracket, double taxExtra)
        {
            var incomeTax = (int) Math.Round((taxOnIncome + (annualSalary - lowerTaxableIncomeBracket) * taxExtra) / AnnualMonths);
            return incomeTax;
        }

        public int CalculateNetIncome(int grossIncome, int incomeTax)
        {
            return grossIncome - incomeTax;
        }

        public int CalculateSuper(int grossIncome, int superRate)
        {
            var super = (int) Math.Round(grossIncome * superRate * 0.01);
            return super;
        }

        public string JoinFirstAndLastNames(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }
    }
}