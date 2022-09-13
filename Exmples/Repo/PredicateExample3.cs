using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exmples
{
    public  class PredicateExample3
    {
        public string Main()
        {           
            Predicate<string> predicate = new Predicate<string>(checkLength);
            bool status = predicate.Invoke("waseem");
                       
            return status.ToString();
        }

        private bool checkLength(string obj)
        {
            if (obj.Length > 5)
            {
                return true;
            }

            return false;
        }
    }
}
