using System;

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

        public void InitialGreeting()
        {
            Console.WriteLine("Welcome to the payslip generator!");
        }

        public EmployeeDetails GetInputDetails()
        {
            return _employeeDetails;
        }

        public void OutputPayslip(Payslip payslip)
        {
            Payslip = payslip;
        }

        public void FarewellMessage()
        {
            Console.WriteLine("Thank you for using MYOB!");
        }
    }
}