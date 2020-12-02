namespace PayslipVer2
{
    public class Tax
    {
        public int TaxOnIncome;
        public int LowerTaxableIncomeBracket;
        public double TaxExtra;
        private readonly int _annualSalary;

        public Tax(int annualSalary)
        {
            _annualSalary = annualSalary;
            // is this good practice???
        }

        public void DetermineTaxApplicableFromAnnualSalary()
        {
            if (_annualSalary >= 180001)
            {
                TaxOnIncome = 54232;
                LowerTaxableIncomeBracket = 180000;
                TaxExtra = 0.45;
            }
            else if(_annualSalary >= 87001)
            {
                TaxOnIncome = 19822;
                LowerTaxableIncomeBracket = 87000;
                TaxExtra = 0.37;
            }
            else if(_annualSalary >= 37001)
            {
                TaxOnIncome = 3572;
                LowerTaxableIncomeBracket = 37000;
                TaxExtra = 0.325;
            }
            else if(_annualSalary >= 18201)
            {
                TaxOnIncome = 0;
                LowerTaxableIncomeBracket = 18200;
                TaxExtra = 0.19;
            }
            else
            {
                TaxOnIncome = 0;
                LowerTaxableIncomeBracket = 0;
                TaxExtra = 0;
            }
        }
    }
}