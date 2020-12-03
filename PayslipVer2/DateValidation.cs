using System;
using System.Globalization;

namespace PayslipVer2
{
    public class DateValidation
    {
        public string StartDate { get; }
        public string EndDate { get; }

        private DateValidation(string startDate, string endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }
        
        public static DateValidation CheckDateInput(string startDate, string endDate)
        {
            var defaultYear = 2020;
            var startDateSplit = startDate.Split(" ");
            var endDateSplit = endDate.Split(" ");

            if (startDateSplit[1] == endDateSplit[1])
            {
                var monthFirstInput = DateTime.ParseExact(startDateSplit[1], "MMMM", CultureInfo.CurrentCulture).Month;
                DateTime dateStart = new DateTime(defaultYear,monthFirstInput, int.Parse(startDateSplit[0]));
                            
                var monthSecondInput = DateTime.ParseExact(endDateSplit[1], "MMMM", CultureInfo.CurrentCulture).Month;
                DateTime dateEnd = new DateTime(defaultYear,monthSecondInput, int.Parse(endDateSplit[0]));

            }
            else
            {
                
            }

            return null;

        }
    }
}