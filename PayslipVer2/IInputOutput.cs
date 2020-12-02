namespace PayslipVer2
{
    public interface IInputOutput
    {
        EmployeeDetails GetInputDetails();
        void OutputPayslip(Payslip payslip);
    }
}