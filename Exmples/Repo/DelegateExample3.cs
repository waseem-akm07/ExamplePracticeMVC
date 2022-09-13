using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exmples
{
    
    public class DelegateExample3
    {
        public delegate T add<T>(T param1, T param2); // generic delegate

        public string Main()
        {
            add<int> sum = Sum;
            sum(10, 20);

            add<string> con = Concat;
            con("Hello ", "World!!");

            return sum.ToString();
        }

        public static int Sum(int val1, int val2)
        {
            return val1 + val2;
        }

        public static string Concat(string str1, string str2)
        {
            return str1 + str2;
        }
    }
}
