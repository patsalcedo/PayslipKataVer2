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
            Console.Write("Please enter your first name: ");
            var firstName = InputValidation.CheckInputIsNotNull();
            Console.Write("Please enter your surname: ");
            var lastName = InputValidation.CheckInputIsNotNull();
            
            Console.Write("Please enter your annual salary: ");
            var annualSalary = InputValidation.CheckIntInput();
            
            Console.Write("Please enter your super: ");
            var superRate = InputValidation.CheckIntInput();
            
            Console.Write("Please enter your payment start date: ");
            var startDate = InputValidation.CheckInputIsNotNull();
            Console.Write("Please enter your payment end date: ");
            var endDate = InputValidation.CheckInputIsNotNull();

            // var payPeriodDates = DateValidation.CheckDateInput(startDate, endDate);
            
            return new EmployeeDetails(firstName, lastName, annualSalary, superRate, startDate, endDate);
        }

        public void OutputPayslip(Payslip payslip)
        {
            Console.WriteLine("\nYour payslip has been generated:\n");
            Console.WriteLine($"Name: {payslip.FullName}");
            Console.WriteLine($"Pay Period: {payslip.PayPeriod}");
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