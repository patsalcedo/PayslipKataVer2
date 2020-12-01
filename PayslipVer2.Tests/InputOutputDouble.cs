namespace PayslipVer2.Tests
{
    public class InputOutputDouble : IInputOutput
    {
        private readonly EmployeeDetails _employeeDetails;

        public InputOutputDouble(EmployeeDetails employeeDetails)
        {
            _employeeDetails = employeeDetails;
        }

        public Payslip Payslip { get; private set; }

        public EmployeeDetails GetInputDetails()
        {
            return _employeeDetails;
        }

        public void OutputPayslip(Payslip payslip)
        {
            Payslip = payslip;
        }
    }
}