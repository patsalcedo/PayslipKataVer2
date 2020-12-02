using System;
using Xunit;

namespace PayslipVer2.Tests
{
    public class PayslipCalculatorTest
    {
        private readonly PayslipCalculator _payslipCalculator;
        
        public PayslipCalculatorTest()
        {
            _payslipCalculator = new PayslipCalculator();
        }
        
        [Theory]
        [InlineData(60050, 5004)]
        [InlineData(120000, 10000)]
        public void Gross_Income_Calculation_Test(int annualSalary, int expectedOutput)
        {
            // WHEN
            var actual = _payslipCalculator.CalculateGrossIncome(annualSalary);

            // THEN
            Assert.Equal(expectedOutput, actual);
        }

        [Fact]
        public void Income_Tax_Calculation_Test()
        {
            // WHEN
            var actual = _payslipCalculator
                .CalculateIncomeTax(60050);

            // THEN
            Assert.Equal(922, actual);
        }
        
        [Theory]
        [InlineData(5004, 922, 4082)]
        [InlineData(10000, 2669, 7331)]
        public void Net_Income_Calculation_Test(int grossIncome, int incomeTax, int expectedOutcome)
        {
            // WHEN
            var actual = _payslipCalculator.CalculateNetIncome(grossIncome,incomeTax);

            // THEN
            Assert.Equal(expectedOutcome, actual);
        }
        
        [Theory]
        [InlineData(5004, 9, 450)]
        [InlineData(10000, 10, 1000)]
        public void Super_Calculation_Test(int grossIncome, int superRate, int expectedOutcome)
        {
            // WHEN
            var actual = _payslipCalculator.CalculateSuper(grossIncome,superRate);

            // THEN
            Assert.Equal(expectedOutcome, actual);
        }

        [Fact]
        public void Join_First_To_Last_Name()
        {
            // WHEN
            var actual = _payslipCalculator.JoinFirstAndLastNames("John", "Doe");
            
            // THEN
            Assert.Equal("John Doe", actual);
        }
        
        // [Fact]
        // public void Pay_Period_Calculation_Test()
        // {
        //     
        // }
        
        // [Fact]
        // public void Throw_Exception_For_Negatives()
        // {
        //     
        // }
    }
}