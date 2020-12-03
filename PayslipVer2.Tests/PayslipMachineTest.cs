using Xunit;

namespace PayslipVer2.Tests
{
    public class PayslipMachineTest
    {
        private readonly PayslipMachine _payslipMachine;
        private readonly InputOutputDouble _inputOutputDouble;
        
        public PayslipMachineTest()
        {
            _inputOutputDouble = new InputOutputDouble(new EmployeeDetails("John","Doe", 60050, 9));
            _payslipMachine = new PayslipMachine(_inputOutputDouble);
        }
        [Fact]
        public void Get_Gross_Income_From_Payslip()
        {
            _payslipMachine.GeneratePayslip();
            Assert.Equal(5004, _inputOutputDouble.Payslip.GrossIncome);
        }
        
        [Fact]
        public void Get_Super_From_Payslip()
        {
            _payslipMachine.GeneratePayslip();
            Assert.Equal(450, _inputOutputDouble.Payslip.Super);
        }

        [Fact]
        public void Get_Fullname_From_Payslip()
        {
            _payslipMachine.GeneratePayslip();
            Assert.Equal("John Doe", _inputOutputDouble.Payslip.FullName);
        }

        [Fact]
        public void Get_Income_Tax_From_Payslip()
        {
            _payslipMachine.GeneratePayslip();
            Assert.Equal(922, _inputOutputDouble.Payslip.IncomeTax);
        }
        
        [Fact]
        public void Get_Net_Income_From_Payslip()
        {
            _payslipMachine.GeneratePayslip();
            Assert.Equal(4082, _inputOutputDouble.Payslip.NetIncome);
        }
    }
}