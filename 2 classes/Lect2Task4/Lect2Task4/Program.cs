using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect2Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            string name;
            int n;
            do
            {
                Console.Clear();
                Console.WriteLine("How many Points are you need? ");
                n = Convert.ToInt32(Console.ReadLine());
            } while ((n<3)||(n>5));
            Point[] A = new Point[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter x");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter y");
                y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter name");
                name = Console.ReadLine();
                A[i] = new Point(x, y, name);
            }
            Figure figure;
            if (n == 3)
                figure = new Figure(A[0], A[1], A[2]);
            else if (n == 4)
                figure = new Figure(A[0], A[1], A[2], A[3]);
            else figure = new Figure(A[0], A[1], A[2], A[3], A[4]);
            figure.PerimeterCalculator();
            Console.ReadKey();
            
        }
    }
    class Point
    {
        double x, y;
        string name;
        public double X
        {
            get
            {
                return x;
            }
        }

        public double Y
        {
            get
            {
                return y;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public Point(double p1, double p2,string na)
        {
            x = p1;
            y = p2;
            name = na;
        }
        
    }
    class Figure
        {
            Point[] point;
            short n;
            public Figure(Point p1,Point p2, Point p3)
            {
                n = 3;
                point = new Point[n];
                point[0] = p1;
                point[1] = p2;
                point[2] = p3;
            }

            public Figure(Point p1, Point p2, Point p3,Point p4)
            {
                n = 4;
                point = new Point[n];
                point[0] = p1;
                point[1] = p2;
                point[2] = p3;
                point[3] = p4;
            }

            public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
            {
                n = 5;
                point = new Point[n];
                point[0] = p1;
                point[1] = p2;
                point[2] = p3;
                point[3] = p4;
                point[4] = p5;
            }
            double LengthSide(Point A, Point B)
            {
                return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
            }

            public void PerimeterCalculator()
            {
                double Perimeter = 0;
            Console.Write("Perimeter of figure ");
                for (int i=0;i<n ;i++)
                {
                    Perimeter = Perimeter + LengthSide(point[i], point[(i + 1) % n]);
                Console.Write(point[i].Name);
                }

                Console.Write(" = " + Math.Round(Perimeter,4));
            }
        }
}
