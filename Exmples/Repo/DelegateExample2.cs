using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exmples
{
    public class DelegateExample2
    {
        public delegate int myDele(int x, int y);
        public string Main()
        {
            DelegateExample2 example2 = new DelegateExample2();

            myDele myDele1 = new myDele(example2.add);
            myDele1(20, 15);

            myDele myDele2 = new myDele(example2.sub);
            myDele2(30, 5);

            return myDele1.ToString();
        }

        public int add(int x, int y)
        {
            return x + y;
        }

        public int sub(int x, int y)
        {
            return x - y;
        }
    }
}
