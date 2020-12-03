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
            var firstName = CheckInputIsNotNull();
            Console.Write("Please enter your surname: ");
            var lastName = CheckInputIsNotNull();
            
            Console.Write("Please enter your annual salary: ");
            var annualSalary = CheckIntInput();
            
            Console.Write("Please enter your super: ");
            var superRate = CheckIntInput();
            
            Console.Write("Please enter your payment start date: ");
            var startDate = CheckInputIsNotNull();
            Console.Write("Please enter your payment end date: ");
            var endDate = CheckInputIsNotNull();

            // var payPeriodDates = DateValidation.CheckDateInput(startDate, endDate);
            
            return new EmployeeDetails(firstName, lastName, annualSalary, superRate, startDate, endDate);
        }

        private static int CheckIntInput()
        {
            var value = CheckInputIsNotNull();
            int valueInt;
            while (!int.TryParse(value, out valueInt))
            {
                Console.Write("Please input a valid integer: ");
                value = Console.ReadLine();
            }
            return valueInt;
        }
        
        private static string CheckInputIsNotNull()
        {
            var value = Console.ReadLine();
            while (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                Console.Write("Please input a value: ");
                value = Console.ReadLine();
            }
            return value;
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