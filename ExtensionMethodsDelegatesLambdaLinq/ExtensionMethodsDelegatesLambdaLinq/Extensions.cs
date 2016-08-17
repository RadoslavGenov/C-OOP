namespace Extensions
{
    using System;
    using System.Text;

    public static class Extensions
    {
        public static StringBuilder SubString(this StringBuilder str, int index, int length)
        {
            StringBuilder updated = new StringBuilder();
            ValidateSubString(str.Length, index, length);
            return updated.Append(str.ToString().Substring(index, length));
        }

        public static void ValidateSubString(int sblength, int index, int length)
        {
            if (index < 0 || index >= sblength)
            {
                throw new IndexOutOfRangeException();
            }
            if ((index + length) > sblength)
            {
                throw new ArgumentOutOfRangeException("Length of SubString is too big");
            }
            if (sblength < 0)
            {
                throw new ArgumentException("Length must be greater than 0");
            }
        }
    }
}
