using System;

namespace PayslipVer2
{
    public class InputValidation
    {
        public static string CheckInputIsNotNull()
        {
            var value = Console.ReadLine();
            while (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                Console.Write("Please input a value: ");
                value = Console.ReadLine();
            }
            return value;
        }
        
        public static int CheckIntInput()
        {
            var value = CheckInputIsNotNull();
            int valueAsInt;
            while (!int.TryParse(value, out valueAsInt))
            {
                Console.Write("Please input a valid integer: ");
                value = Console.ReadLine();
            }
            while (valueAsInt < 1)
            {
                Console.Write("Please input a valid positive integer: ");
                valueAsInt = Convert.ToInt32(CheckInputIsNotNull());
            }
            return valueAsInt;
        }
    }
}