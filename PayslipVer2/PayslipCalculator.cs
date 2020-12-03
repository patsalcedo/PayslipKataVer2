using System;
using System.Globalization;

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
        
        public String CalculatePayPeriod(string startDate, string endDate)
        {
            var defaultYear = 2020;
            var startDateSplit = startDate.Split(" ");
            var endDateSplit = endDate.Split(" ");

            var monthFirstInput = DateTime.ParseExact(startDateSplit[1], "MMMM", CultureInfo.CurrentCulture).Month;
            DateTime dateStart = new DateTime(defaultYear,monthFirstInput, int.Parse(startDateSplit[0]));
            
            var monthSecondInput = DateTime.ParseExact(endDateSplit[1], "MMMM", CultureInfo.CurrentCulture).Month;
            DateTime dateEnd = new DateTime(defaultYear,monthSecondInput, int.Parse(endDateSplit[0]));
            
            return $"{dateStart:dd MMMM}" + " - " + $"{dateEnd:dd MMMM}";
        }

        public int CalculateGrossIncome(double annualSalary)
        {
            return (int) Math.Round(annualSalary / AnnualMonths);
        }
        
        public int CalculateIncomeTax(int annualSalary)
        {
            var tax = TaxBracket.GetTaxForAnnualSalary(annualSalary);

            return (int) Math.Round((tax.TaxOnIncome + (annualSalary - tax.LowerTaxableIncomeBracket) * tax.TaxRate) / AnnualMonths);
        }

        public int CalculateNetIncome(int grossIncome, int incomeTax)
        {
            return grossIncome - incomeTax;
        }

        public int CalculateSuper(int grossIncome, double superRate)
        {
            return (int) Math.Round(grossIncome * superRate * ConvertPercentageToDecimalValue);
        }
    }
}