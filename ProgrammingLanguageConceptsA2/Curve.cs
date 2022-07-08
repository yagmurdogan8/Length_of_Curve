//@author YD

using System;
using System.Collections.Generic;
using System.Text;


namespace ProgrammingLanguageConceptsA2
{
    class Curve : ICloneable
    {
        List<Point> pointList = new List<Point>();

        public object Clone() //Deep Copy
        {
            Curve copied = new Curve();

            foreach(Point p in pointList)
            {
                Point newPoint = new Point(p.PointX, p.PointY);

                copied.AddPoint(newPoint);
            }

            return copied;
        }

        public Curve ShallowCopy()
        {
            return (Curve)MemberwiseClone();
        }
        public void PrintPoints()
        {
            for (int i = 0; i < pointList.Count; i++)
            {
                Console.WriteLine("Points have printed for point " + (i + 1) + " (x, y) : " 
                    + pointList[i].PointX + " " + pointList[i].PointY);
            }            
        }

        public void AddPoint(Point pointAdd)
        {
            //checking whether the list is empty or not
            if(pointList.Count == 0)
            {
                pointAdd.Length = 0;
            }

            else
            {
                Point lastPoint = pointList[^1];
                pointAdd.Length = Math.Sqrt(Math.Pow(lastPoint.PointX - pointAdd.PointX,2) +
                    Math.Pow(lastPoint.PointY - pointAdd.PointY,2));
            }

            pointList.Add(pointAdd);

        }

        public void RemovePoint(Point pointRemove)
        {

            if (pointList[0] == pointRemove)
            {
                pointList[1].Length = 0;
            }

            else
            {
                if (pointList[^1] != pointRemove)
                pointList[pointList.IndexOf(pointRemove) + 1].Length += pointRemove.Length;
            }
            pointList.Remove(pointRemove);

        }
        public double CurveLength()
        {
            double sum = 0;

            foreach (Point p in pointList)
            {
                sum += p.Length;
            }

            return sum;
        }
        public static Boolean operator <(Curve c1, Curve c2)
        {
            return c1.CurveLength() < c2.CurveLength();
        }
        public static Boolean operator >(Curve c1, Curve c2)
        {
            return c1.CurveLength() > c2.CurveLength();
        }
    }
}
