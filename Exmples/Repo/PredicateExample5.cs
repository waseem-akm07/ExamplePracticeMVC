using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exmples.ViewModel;

namespace Exmples
{
    public class PredicateExample5
    {
        public Employee Main()
        {
            var employees = new List<Employee>{
                new Employee{Age= 20, Name= "Rahul"},
                new Employee{Age= 21, Name= "Amit"},
                new Employee{Age= 22, Name= "Ankit"},
                new Employee{Age= 23, Name= "Ritesh"}
            };

            var findByAgePredicate = new Predicate<Employee>(FindByAge);
            var findByNamePredicate = new Predicate<Employee>(FindByName);

            var agePredicate = employees.Find(findByAgePredicate);
            var namePredicate = employees.Find(findByNamePredicate);

           Employee employee = new Employee();

            if (agePredicate != null || namePredicate != null)
            {         
                employee = agePredicate ;
                employee = namePredicate;
            }

            return employee;
        }

        private  bool FindByName(Employee obj)
        {
            return obj.Name == "Amit";
        }

        private  bool FindByAge(Employee obj)
        {
            return obj.Age > 21;
        }
    }
}
