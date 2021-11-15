using System;

namespace Open_Lab_04._02
{
    public class Doubler
    {
        public string DoubleChar(string original)
        {
            string dvojite = string.Empty;
            for (int i = 0; i < original.Length; i++)
            {
                string a = Convert.ToString(original[i]) + original[i];
                dvojite = dvojite + a;
            }
            return dvojite;
        }
    }
}
