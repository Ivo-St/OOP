using System;
namespace LaptopShop
{
    public static class Validator
    {
        public static void checkString(string value, string property)
        {
            if (value != null && value.Length<1)
            {
                throw new ArgumentNullException(property + " cannot be empty");
            }
        }

        public static void checkInt(int value, string property)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(property + " cannot be negative");
            }
        }

        public static void checkDouble(double value, string property)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(property + " cannot be negative");
            }
        }

        public static bool IsValidString(string value)
        {
            return !string.IsNullOrEmpty(value);
        }

        public static bool IsValidInt(int? value)
        {
            return value.HasValue;
        }

        public static bool IsValidDouble(double? value)
        {
            return value.HasValue;
        }

        public static bool IsValidBattery(Battery value)
        {
            return value == null;
        }
    }
}
