namespace PayslipVer2
{
    public class EmployeeDetails
    {
        public string FirstName;
        public string LastName;
        public int AnnualSalary;
        public int SuperRate;

        public EmployeeDetails(string firstName, string lastName, int annualSalary, int superRate)
        {
            FirstName = firstName;
            LastName = lastName;
            AnnualSalary = annualSalary;
            SuperRate = superRate;
        }
    }
}