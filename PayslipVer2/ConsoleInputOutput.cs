using System;

namespace PayslipVer2
{
    public class ConsoleInputOutput : IInputOutput
    {
        public void InitialGreeting()
        {
            Console.WriteLine("Welcome to the payslip generator!\n");
        }

        public EmployeeDetails GetInputDetails()
        {
            Console.Write("Please enter your name: ");
            var firstName = Console.ReadLine();
            Console.Write("Please enter your surname: ");
            var lastName = Console.ReadLine();
            Console.Write("Please enter your annual salary: ");
            var annualSalaryString = Console.ReadLine();
            int.TryParse(annualSalaryString, out var annualSalary);
            Console.Write("Please enter your super: ");
            var superString = Console.ReadLine();
            int.TryParse(superString, out var superRate);
            
            return new EmployeeDetails(){FirstName = firstName, LastName = lastName, AnnualSalary = annualSalary, SuperRate = superRate};
        }

        public void OutputPayslip(Payslip payslip)
        {
            Console.WriteLine("\nYour payslip has been generated:\n");
            Console.WriteLine($"Name: {payslip.FullName}");
            Console.WriteLine($"Gross Income: {payslip.GrossIncome}");
            Console.WriteLine($"Income Tax: {payslip.IncomeTax}");
            Console.WriteLine($"Net Income: {payslip.NetIncome}");
            Console.WriteLine($"Super: {payslip.Super}");
        }

        public void FarewellMessage()
        {
            Console.WriteLine("\nThank you for using MYOB!");
        }
    }
}