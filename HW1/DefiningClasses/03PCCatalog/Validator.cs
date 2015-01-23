using System;
namespace PCCatalog
{
    public static class Validator
    {
        public static void CheckString(string value, string property)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentNullException(property + " cannot be null or empty");
        }

        public static void CheckNullString(string value, string property)
        {
            if (value !=null && value.Length<1)
                throw new ArgumentNullException(property + " cannot be empty");
        }

        public static void CheckDouble(double value, string property)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(property + " cannot be negative number");
        }

        public static bool IsValidComponent(Component value)
        {
            if (value == null)
                return false;
            return true;
        }
    }
}
