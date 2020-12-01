using Xunit;

namespace PayslipVer2.Tests
{
    public class PayslipMachineTest
    {
        [Fact]
        public void Get_GrossIncome_From_Payslip()
        {
            var inputOutputDouble = new InputOutputDouble(new EmployeeDetails(){AnnualSalary = 60050});
            var payslipMachine = new PayslipMachine(inputOutputDouble);
            payslipMachine.GeneratePayslip();
            
            Assert.Equal(5004, inputOutputDouble.Payslip.GrossIncome);
        }
        
        [Fact]
        public void Get_Super_From_Payslip()
        {
            var inputOutputDouble = new InputOutputDouble(new EmployeeDetails(){AnnualSalary = 60050, SuperRate = 9});
            var payslipMachine = new PayslipMachine(inputOutputDouble);
            payslipMachine.GeneratePayslip();
            
            Assert.Equal(450, inputOutputDouble.Payslip.Super);
        }
        
    }
}