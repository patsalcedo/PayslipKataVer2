namespace PayslipVer2
{
    public interface IInputOutput
    {
        void InitialGreeting();
        EmployeeDetails GetInputDetails();
        void OutputPayslip(Payslip payslip);
        void FarewellMessage();
    }
}