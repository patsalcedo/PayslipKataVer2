using PayslipVer2.Tests;

namespace PayslipVer2
{
    public class PayslipMachine
    {
        private readonly IInputOutput _inputOutput;

        public PayslipMachine(IInputOutput inputOutput)
        {
            _inputOutput = inputOutput;
        }

        public void GeneratePayslip()
        {
            var testTaxOnIncome = 3572;
            var testLowerTaxableIncomeBracket = 37000;
            var testTaxExtra = 0.325;
            
            var inputDetails = _inputOutput.GetInputDetails();
            var payslip = new Payslip();
            var payslipCalculator = new PayslipCalculator();
            payslip.FullName = payslipCalculator.JoinFirstAndLastNames(inputDetails.FirstName, inputDetails.LastName);
            payslip.GrossIncome = payslipCalculator.CalculateGrossIncome(inputDetails.AnnualSalary);
            payslip.IncomeTax = payslipCalculator
                .CalculateIncomeTax(testTaxOnIncome, inputDetails.AnnualSalary, testLowerTaxableIncomeBracket,
                    testTaxExtra);
            payslip.NetIncome = payslipCalculator.CalculateNetIncome(payslip.GrossIncome, payslip.IncomeTax);
            payslip.Super = payslipCalculator.CalculateSuper(payslip.GrossIncome, inputDetails.SuperRate);
            _inputOutput.OutputPayslip(payslip);
        }
    }
}