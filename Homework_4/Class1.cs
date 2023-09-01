namespace Homework_4
{
    #region Triangle
    public class Triangle
    {
        public double GetAreaBaseAndHeight(double a, double h)
        {
            return a * h / 2;
        }

        public double GetArea(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public double GetArea(double a, double b, int angle)
        {
            return a * b * Math.Sin(angle) / 2;
        }

        public double GetArea(double a, double b, double c, double R)
        {
            return a * b * c / 4 * R;
        }

        public double GetArea(double p, double r)
        {
            return p * r;
        }

        public double GetPerimeter(double a, double b, double c)
        {
            return a + b + c;
        }
    }
    #endregion

    #region Square
    public class Square
    {
        public double GetAreaByBase(double a)
        {
            return Math.Pow(a , 2);
        }

        public double GetAreaByDiagonal(double d)
        {
            return Math.Pow(d , 2) / 2;
        }

        public double GetPerimeterByBase(double a)
        {
            return 4 * a;
        }

        public double GetPerimeterByDiagonal(double d)
        {
            return 2 * Math.Sqrt(2) * d;
        }
    }
    #endregion

    #region Rectangle
    public class Rectangle
    {
        public double GetArea(double a, double b)
        {
            return a * b;
        }
        public double GetPerimeter(double a, double b)
        {
            return 2 * (a + b);
        }
    }
    #endregion

    #region Rhombus
    public class Rhombus
    {
        public double GetArea(double a, double h)
        {
            return a * h;
        }
        public double GetArea(double a, int angle)
        {
            return Math.Pow(a , 2) * Math.Sign(angle);
        }
        public double GetAreaByDiagonals(double d1, double d2)
        {
            return d1 * d2 / 2;
        }
        public double GetPerimeter(double a)
        {
            return 4 * a;
        }
    }
    #endregion

    #region Parallelogram
    public class Parallelogram
    {
        public double GetArea(double a, double h)
        {
            return a * h;
        }
        public double GetArea(double a, double b, int angle)
        {
            return a * b * Math.Sin(angle);
        }
        public double GetAreaByDiagonalsAndAngle(double d1, double d2, int angle)
        {
            return d1 * d2 * Math.Sin(angle) / 2;
        }
        public double GetPerimeter(double a, double b)
        {
            return (a + b) * 2;
        }

    }
    #endregion

    #region Trapeze
    public class Trapeze
    {
        public double GetArea(double a, double b, double h)
        {
            return (a + b) * h / 2;
        }
        public double GetArea(double a, double b, double c, double d)
        {
            double p = (a + b + c) / 2;
            return ((a + b) / Math.Abs(a - b)) * Math.Sqrt((p - a) * (p - b) * (p - a - c) * (p - a - d));
        }
        public double GetPerimeter(double a, double b, double c, double d)
        {
            return a + b + c + d;
        }

    }
    #endregion

    #region Circle
    public class Circle
    {
        public double GetArea(double r)
        {
            return Math.PI * Math.Pow(r , 2);
        }

        public double GetAreaByDiameter(double d)
        {
            return Math.PI * Math.Pow(d, 2) / 4;
        }
        public double GetLength(double r)
        {
            return 2 * Math.PI * r;
        }
        public double GetLengthByDiameter(double d)
        {
            return Math.PI * d;
        }
    }
    #endregion

    #region Ellipse
    public class Ellipse
    {
        public double GetArea(double a, double b)
        {
            return Math.PI * a * b;
        }

    }
    #endregion

    #region Quadrangle
    public class Quadrangle
    {
        public double GetArea(double d1, double d2, double angle)
        {
            return d1 * d2 * Math.Sin(angle) / 2;
        }
        public double GetArea(double p, double r)
        {
            return p * r;
        }
        public double GetArea(double a, double b, double c, double d, double angle1, double angle2)
        {
            double p = (a + b + c + d) / 2;
            return Math.Sqrt((p - a) * (p - b) * (p - c) * (p - d) - a * b * c * d * Math.Pow(Math.Cos((angle1 + angle2) / 2), 2));
        }
        public double GetArea(double a, double b, double c, double d)
        {
            double p = (a + b + c + d) / 2;
            return Math.Sqrt((p - a) * (p - b) * (p - c) * (p - d));
        }
        public double GetPerimeter(double a, double b, double c, double d)
        {
            return a + b + c + d;
        }
    }
    #endregion

    #region Volume
    public static class Volume
    {
        public static double Cube(double a)
        {
            return Math.Pow(a, 3);
        }
        public static double Prism(double s, double h)
        {
            return s * h;
        }
        public static double Parallelepiped(double s, double h)
        {
            return s * h;
        }
        public static double RecParallelepiped(double a, double b, double h)
        {
            return a * b * h;
        }
        public static double Pyramid(double s, double h)
        {
            return s * h / 3;
        }
        public static double Cylinder(double s, double h)
        {
            return s * h;
        }
        public static double Cone(double s, double h)
        {
            return s * h / 3;
        }
        public static double Ball(double R)
        {
            return 4 * Math.PI * Math.Pow(R , 3) / 3;
        }
    }
    #endregion
}