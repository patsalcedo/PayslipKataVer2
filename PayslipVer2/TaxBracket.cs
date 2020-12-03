using System.Collections.Generic;
using System.Linq;

namespace PayslipVer2
{
    public class TaxBracket
    {
        public int TaxOnIncome { get; }
        public int LowerTaxableIncomeBracket { get; }
        public double TaxRate { get; }

        private TaxBracket(int taxOnIncome, int lowerTaxableIncomeBracket, double taxRate)
        {
            TaxOnIncome = taxOnIncome;
            LowerTaxableIncomeBracket = lowerTaxableIncomeBracket;
            TaxRate = taxRate;
        }

        private static readonly List<TaxBracket> TaxBrackets = new List<TaxBracket>()
        {
            new TaxBracket(54232, 180000, 0.45),
            new TaxBracket(19822, 87000, 0.37),
            new TaxBracket(3572, 37000, 0.325),
            new TaxBracket(0, 18200, 0.19),
            new TaxBracket(0,0,0)
        };
        
        public static TaxBracket GetTaxForAnnualSalary(int annualSalary)
        {
            // foreach (var taxBracket in TaxBrackets)
            // {
            //     if (annualSalary > taxBracket.LowerTaxableIncomeBracket)
            //     {
            //         return taxBracket;
            //     }
            // }
            // return new TaxBracket(0, 0, 0);
            return TaxBrackets.First(taxBracket => annualSalary > taxBracket.LowerTaxableIncomeBracket);
        }
    }
}