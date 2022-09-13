using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exmples
{
    public class DelegateExample1
    {
        public delegate double rectDelegate(double height, double width);
        public string Main()
        {
            // creating object of class  
            // "rectangle", named as "rect" 
            DelegateExample1 rect = new DelegateExample1();

            // creating delegate object, name as "rectdele" 
            // and pass the method as parameter by  
            // class object "rect" 
            rectDelegate rectdele = new rectDelegate(rect.area);

            // call 2nd method "perimeter" 
            // Multicasting 
            rectdele += rect.perameter;

            // pass the values in two method  
            // by using "Invoke" method 
          double result =  rectdele.Invoke(6.3, 4.2);

            return result.ToString();

        }

        public double area(double height, double width)
        {
            double result = height * width;
            return result;
        }

        public double perameter(double height, double width)
        {
            double result = 2 * (height + width);
            return result;
        }
    }
}
