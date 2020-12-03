namespace PayslipVer2
{
    public class EmployeeDetails
    {
        public string FirstName;
        public string LastName;
        public int AnnualSalary;
        public int SuperRate;
        public string StartDate;
        public string EndDate;

        public EmployeeDetails(string firstName, string lastName, int annualSalary, int superRate, string startDate, string endDate)
        {
            FirstName = firstName;
            LastName = lastName;
            AnnualSalary = annualSalary;
            SuperRate = superRate;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}