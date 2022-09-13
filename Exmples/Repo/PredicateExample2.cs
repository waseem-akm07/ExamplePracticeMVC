using System;

namespace Exmples
{
    public class PredicateExample2
    {        
        public string ExMain()
        {
            Predicate<int> num = IsGreaterthanZero;

            bool result = num(10);

                      
            return result.ToString();
        }

        // Method 
        public static bool IsGreaterthanZero(int a)
        {
            bool i = false;

            if (a > 0)
            {
                i = true;
            }

            return i;
        }
    }
}
