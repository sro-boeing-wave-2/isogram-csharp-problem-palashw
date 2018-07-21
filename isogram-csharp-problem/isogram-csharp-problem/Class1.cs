using System;

namespace isogram_csharp_problem
{
    public class isogram
    {
        public static int Check_isogram (string str)
        {
            str = str.ToLower();
            char[] sortstr = str.ToCharArray();

            Array.Sort(sortstr);

            for (int i = 0; i < str.Length-1; i++)
            {
                if (sortstr[i] == sortstr[i + 1])
                {
                    return 0;
                }
            }
            return 1;
 
        }
    }
}
