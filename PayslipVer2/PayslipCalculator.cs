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
            // "1 March" "31 March"
            var defaultYear = 2020;
            var startDateSplit = startDate.Split(" ");
            var endDateSplit = endDate.Split(" ");

            var month = DateTime.ParseExact(startDateSplit[1], "MMMM", CultureInfo.CurrentCulture).Month;
            
            DateTime dateStart = new DateTime(defaultYear,month, int.Parse(startDateSplit[0])); // ends up as 1/1/0001
                // DateTime.Parse(startDate); // 1/3/2020 (no year supplied so it assumes current year)
            // DateTime dateEnd = DateTime.Parse(endDateSplit[1]); // 31/3/2020 (no year supplied so it assumes current year)
            
            // if (startDateSplit[1] == endDateSplit[1]) // check both same month
            // {
            //     
            // }

            return dateStart.Day.ToString();
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