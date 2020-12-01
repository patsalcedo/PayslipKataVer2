using System;
using Xunit;

namespace PayslipVer2.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(60050, 5004)]
        [InlineData(120000,10000)]
        public void Gross_Income_Calculation_Test(int annualSalary, int expectedOutput)
        {
            // GIVEN
            var payslipCalculator = new PayslipCalculator();

            // WHEN
            var actual = payslipCalculator.CalculateGrossIncome(annualSalary);

            // THEN
            Assert.Equal(expectedOutput, actual);
        }
        
        [Theory]
        [InlineData(5004, 922, 4082)]
        [InlineData(10000,2669,7331)]
        public void Net_Income_Calculation_Test(int grossIncome, int incomeTax, int expectedOutcome)
        {
            // GIVEN
            var payslipCalculator = new PayslipCalculator();

            // WHEN
            var actual = payslipCalculator.CalculateNetIncome(grossIncome,incomeTax);

            // THEN
            Assert.Equal(expectedOutcome, actual);
        }
        
        [Theory]
        [InlineData(5004, 9, 450)]
        [InlineData(10000,10,1000)]
        public void Super_Calculation_Test(int grossIncome, int superRate, int expectedOutcome)
        {
            // GIVEN
            var payslipCalculator = new PayslipCalculator();

            // WHEN
            var actual = payslipCalculator.CalculateSuper(grossIncome,superRate);

            // THEN
            Assert.Equal(expectedOutcome, actual);
        }
    }
}