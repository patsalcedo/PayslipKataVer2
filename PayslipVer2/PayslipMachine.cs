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
            payslip.FullName = payslipCalculator.JoinFirstAndLastNames(inputDetails.FirstName, inputDetails.LastName);
            payslip.PayPeriod = payslipCalculator.CalculatePayPeriod(inputDetails.StartDate, inputDetails.EndDate);
            payslip.GrossIncome = payslipCalculator.CalculateGrossIncome(inputDetails.AnnualSalary);
            payslip.IncomeTax = payslipCalculator.CalculateIncomeTax(inputDetails.AnnualSalary);
            payslip.NetIncome = payslipCalculator.CalculateNetIncome(payslip.GrossIncome, payslip.IncomeTax);
            payslip.Super = payslipCalculator.CalculateSuper(payslip.GrossIncome, inputDetails.SuperRate);
            _inputOutput.OutputPayslip(payslip);
        }
    }
}