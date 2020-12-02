using System;

namespace PayslipVer2
{
    public class PayslipCalculator
    {
        private const int AnnualMonths = 12;
        private const double ConvertPercentageToDecimalValue = 0.01;

        public string JoinFirstAndLastNames(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }

        public int CalculateGrossIncome(double annualSalary)
        {
            return (int) Math.Round(annualSalary / AnnualMonths);
        }
        
        public int CalculateIncomeTax(int annualSalary)
        {
            var tax = new Tax(annualSalary);
            tax.DetermineTaxApplicableFromAnnualSalary();

            return (int) Math.Round((tax.TaxOnIncome + (annualSalary - tax.LowerTaxableIncomeBracket) * tax.TaxExtra) / AnnualMonths);
        }

        public int CalculateNetIncome(int grossIncome, int incomeTax)
        {
            return grossIncome - incomeTax;
        }

        public int CalculateSuper(int grossIncome, int superRate)
        {
            return (int) Math.Round(grossIncome * superRate * ConvertPercentageToDecimalValue);
        }
    }
}