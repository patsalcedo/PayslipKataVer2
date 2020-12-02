using System;

namespace PayslipVer2
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoleInputOutput = new ConsoleInputOutput();
            var payslipMachine = new PayslipMachine(consoleInputOutput);
            payslipMachine.GeneratePayslip();
        }
    }
}