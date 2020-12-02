using Xunit;

namespace PayslipVer2.Tests
{
    public class PayslipMachineTest
    {
        [Fact]
        public void Get_Gross_Income_From_Payslip()
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

        [Fact]
        public void Get_Fullname_From_Payslip()
        {
            var inputOutputDouble = new InputOutputDouble(new EmployeeDetails(){FirstName = "John", LastName = "Doe"});
            var payslipMachine = new PayslipMachine(inputOutputDouble);
            payslipMachine.GeneratePayslip();
            
            Assert.Equal("John Doe", inputOutputDouble.Payslip.FullName);
        }

        [Fact]
        public void Get_Income_Tax_From_Payslip()
        {
            var inputOutputDouble = new InputOutputDouble(new EmployeeDetails(){AnnualSalary = 60050});
            var payslipMachine = new PayslipMachine(inputOutputDouble);
            payslipMachine.GeneratePayslip();
            
            Assert.Equal(922, inputOutputDouble.Payslip.IncomeTax);
        }
        
        [Fact]
        public void Get_Net_Income_From_Payslip()
        {
            var inputOutputDouble = new InputOutputDouble(new EmployeeDetails(){AnnualSalary = 60050});
            var payslipMachine = new PayslipMachine(inputOutputDouble);
            payslipMachine.GeneratePayslip();
            
            Assert.Equal(4082, inputOutputDouble.Payslip.NetIncome);
        }

    }
}