using System;

namespace PayslipVer2
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoleInputOutput = new ConsoleInputOutput();
            consoleInputOutput.InitialGreeting();
            var payslipMachine = new PayslipMachine(consoleInputOutput);
            payslipMachine.GeneratePayslip();
            consoleInputOutput.FarewellMessage();
        }
    }
}