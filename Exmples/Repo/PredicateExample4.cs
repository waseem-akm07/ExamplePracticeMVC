using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exmples
{
    public class PredicateExample4
    {
        public string Main()
        {
            CarClassify car = new CarClassify();
            return car.classify();
        }

       
    }

    public class CarClassify
    {
        public string classify()
        {
            List<string> cars = new List<string>(new string[] {
               "Honda Civic", "Baleno", "Creata", "S Cross", "Swift"
           });

            cars.Find(new EndsWith("ss").Match);

            EndsWith ends = new EndsWith("Civic");
            cars.Find(ends.Match);

            ends.Suffix = "ft";
            cars.Find(ends.Match);

            return cars.ToString();
        }
    }

    public class EndsWith
    {
        private string m_Suffix;

        // Initializes with suffix we want to match.
        public EndsWith(string Suffix)
        {
            m_Suffix = Suffix;
        }

        public string Suffix
        {
            get { return m_Suffix; }
            set { m_Suffix = value; }
        }

        // Gets the predicate.  Now it's possible to re-use this predicate with 
        // various suffixes.
        public Predicate<string> Match
        {
            get { return IsMatch; }
        }

        private bool IsMatch(string obj)
        {
            if((obj.Length>=m_Suffix.Length)&&
                (obj.Substring(obj.Length - m_Suffix.Length).ToLower() 
                == m_Suffix.ToLower()))
            {
                return true;
            }

            return false;
        }
    }
}
