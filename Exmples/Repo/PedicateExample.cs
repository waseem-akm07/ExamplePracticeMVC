using System;
using System.Drawing;
using Exmples.ViewModel;


namespace Exmples
{
    public class PedicateExample : IPredicate
    {
       // first..................
        public  string Main()
        {
            //create an array of point structures
            Point[] points = {new Point(100, 200),
                                new Point(150, 250),
                                new Point(250, 375),
                                new Point(275, 395),
                                new Point(295, 450) };

            //define the Peedicate<T> delegate
            Predicate<Point> predicate = FindPoint;

            //find the first point structure for which x time y
            // is grater than 100000.
            Point first = Array.Find(points, predicate);

            //display the first structure found 
            Console.Clear();
            Console.WriteLine("Found: X = {0}, Y = {1}", first.X, first.Y);
          
            return first.ToString();
        }

        private static bool FindPoint(Point obj)
        {
            return obj.X * obj.Y > 100000;

           // return obj.X * obj.Y < 100000;

            // return obj.X * obj.Y != 100000;
        }


        // second.................
        public string PredicateMain2()
        {
            PredicateExample2 example2 = new PredicateExample2();

            return example2.ExMain();
        }


        // third..............
        public string PredicateMain3()
        {
            PredicateExample3 predicateExample3 = new PredicateExample3();
            
            return predicateExample3.Main();
        }


        // fifth............
        public Employee PredicateMain5()
        {
            PredicateExample5 predicateExample5 = new PredicateExample5();

            return predicateExample5.Main();
        }

        
        // fourth..............
        public string PredicateMain4()
        {
            PredicateExample4 predicateExample4 = new PredicateExample4();

            return predicateExample4.Main();
        }


        // fifth delegate multicast
        public string DelegateMulticast()
        {
            DelegateExample1 delegateExample1 = new DelegateExample1();

            return delegateExample1.Main();
        }

        public string DelegateSinglecast()
        {
            DelegateExample2 delegateExample2 = new DelegateExample2();

            return delegateExample2.Main();          
        }

        public string DelegateGeneric()
        {
            DelegateExample3 delegateExample3 = new DelegateExample3();

            return delegateExample3.Main();
        }
    }
}
