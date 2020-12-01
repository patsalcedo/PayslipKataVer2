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
            var inputDetails = _inputOutput.GetInputDetails();
            var payslip = new Payslip();
            var payslipCalculator = new PayslipCalculator();
            payslip.GrossIncome = payslipCalculator.CalculateGrossIncome(inputDetails.AnnualSalary);
            payslip.Super = payslipCalculator.CalculateSuper(payslip.GrossIncome,inputDetails.SuperRate);
            _inputOutput.OutputPayslip(payslip);
        }
    }
}