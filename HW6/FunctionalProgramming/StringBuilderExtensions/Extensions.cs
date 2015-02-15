namespace StringBuilderExtensions
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    public static class Extensions
    {
        public static string Substring(this StringBuilder stringBuilder, int startIndex, int length)
        {
            if (startIndex < 0 || startIndex > stringBuilder.Length)
            {
                throw new IndexOutOfRangeException("Start index is out of range");
            }

            if (startIndex + length > stringBuilder.Length)
            {
                throw new ArgumentOutOfRangeException("Length is too big");
            }

            if (length <= 0)
            {
                throw new ArgumentOutOfRangeException("Length cannot be negative or zero");
            }

            return stringBuilder.ToString(startIndex, length);
        }

        public static StringBuilder RemoveText(this StringBuilder stringBuilder, string text)
        {
            return stringBuilder.Replace(text, "");
        }

        public static StringBuilder AppendAll<T>(this StringBuilder stringBuilder, IEnumerable<T> list, string separator="")
        {
            return stringBuilder.Append(string.Join<T>(separator, list));
        }
    }
}
