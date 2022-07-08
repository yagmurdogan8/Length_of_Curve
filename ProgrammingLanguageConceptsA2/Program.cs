//@author YD

using System;

namespace ProgrammingLanguageConceptsA2
{
    class Program
    {
        static void Main(string[] args)
        {                    
            //creating curve objets from Curve class

            Curve curve1 = new Curve();
            Curve curve2 = new Curve();
            Curve curve3 = new Curve();

            //creating point objects from Point class 

            Point point1 = new Point (8, 6);
            Point point2 = new Point (3, 1);
            Point point3 = new Point (6, 5);
            Point point4 = new Point (1, 1);
            Point point5 = new Point (9, 8);
            Point point6 = new Point (5, 14);
            Point point7 = new Point (12, 18);
            Point point8 = new Point (15, 6);
            Point point9 = new Point (22, 14);
            Point point10 = new Point (25, 32);
            Point point11 = new Point (34, 42);
            Point point12 = new Point (35, 43);

            //adding points to curve objects in order to fill curve objects : curve 1 

            curve1.AddPoint(point1);
            curve1.AddPoint(point2);
            curve1.AddPoint(point3);
            curve1.AddPoint(point4);

            //adding points to curve objects in order to fill curve objects : curve 2

            curve2.AddPoint(point5);
            curve2.AddPoint(point6);
            curve2.AddPoint(point7);
            curve2.AddPoint(point8);

            //adding points to curve objects in order to fill curve objects : curve 3

            curve3.AddPoint(point9);
            curve3.AddPoint(point10);
            curve3.AddPoint(point11);
            curve3.AddPoint(point12);

            Console.WriteLine("Curve 1:");
            curve1.PrintPoints();
            Console.WriteLine();

            Console.WriteLine("Curve 2:");
            curve2.PrintPoints();
            Console.WriteLine();

            Console.WriteLine("Curve 3:");
            curve3.PrintPoints();
            Console.WriteLine();

            Console.WriteLine("Curve 1's length = " + curve1.CurveLength());
            Console.WriteLine("Curve 2's length = " + curve2.CurveLength());
            Console.WriteLine("Curve 3's length = " + curve3.CurveLength());
            Console.WriteLine();

            Console.WriteLine("The distance between the first and the initial point of the first curve = " + point1.Length);
            Console.WriteLine("The distance between the second and the first points of the first curve = " + point2.Length);
            Console.WriteLine("The distance between the third and the second points of the first curve = " + point3.Length);
            Console.WriteLine("The distance between the fourth and the third points of the first curve = " + point4.Length);
            Console.WriteLine();

            Console.WriteLine("The distance between the first and the initial point of the second curve = " + point5.Length);
            Console.WriteLine("The distance between the second and the first points of the second curve = " + point6.Length);
            Console.WriteLine("The distance between the third and the second points of the second curve = " + point7.Length);
            Console.WriteLine("The distance between the fourth and the third points of the second curve = " + point8.Length);
            Console.WriteLine();

            Console.WriteLine("The distance between first and the initial point of the third curve = " + point9.Length);
            Console.WriteLine("The distance between the second and the first points of the third curve = " + point10.Length);
            Console.WriteLine("The distance between the third and the second points of the third curve = " + point11.Length);
            Console.WriteLine("The distance between the fourth and the third points of the third curve = " + point12.Length);
            Console.WriteLine();

            curve1.RemovePoint(point1);
            Console.WriteLine("Updated Curve 1 after removing points:");
            curve1.PrintPoints();
            Console.WriteLine();

            Console.WriteLine("Is Curve 1's lenght less than Curve 2's? : " + (curve1 < curve2));
            Console.WriteLine("Is Curve 1's lenght bigger than Curve 2's? : " + (curve1 > curve2));
            Console.WriteLine("Is Curve 2's lenght bigger than Curve 3's? : " + (curve2 > curve3));
            Console.WriteLine("Is Curve 3's lenght less than Curve 2's? : " + (curve3 < curve2));
            Console.WriteLine();

            Console.WriteLine("The distance between the second and the first points of the first curve = " + (point2 - point1));
            Console.WriteLine("The distance between the fourth and the third points of the third curve = " + (point12 - point11));
        }
    }
}
