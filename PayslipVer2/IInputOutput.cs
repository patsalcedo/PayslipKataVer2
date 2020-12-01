namespace PayslipVer2.Tests
{
    public interface IInputOutput
    {
        EmployeeDetails GetInputDetails();
        void OutputPayslip(Payslip payslip);
    }
}