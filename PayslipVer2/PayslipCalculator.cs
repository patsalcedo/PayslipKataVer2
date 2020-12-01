using System;

namespace PayslipVer2
{
    public class PayslipCalculator
    {
        public int CalculateGrossIncome(double annualSalary)
        {
            var sum = (int) Math.Round(annualSalary / 12);
            return sum;
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
    }
}