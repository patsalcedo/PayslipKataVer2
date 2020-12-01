namespace PayslipVer2
{
    public class Payslip
    {
        private string _name;
        private string _payPeriod;
        private int _grossIncome;
        private int _incomeTax;
        private int _netIncome;
        private int _super;

        public Payslip(string firstname, string lastname, string payPeriod, int grossIncome, int incomeTax, int netIncome, int super)
        {
            _name = firstname + " " + lastname;
            _payPeriod = payPeriod;
            _grossIncome = grossIncome;
            _incomeTax = incomeTax;
            _netIncome = netIncome;
            _super = super;
        }
    }
}