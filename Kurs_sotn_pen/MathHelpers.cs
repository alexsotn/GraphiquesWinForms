using System;

	namespace Kurs_sotn_pen
{
    public static class MathHelpers
    {
        /// <summary>
        /// Нахождение промежуточных значений, в данном случае для отрезка. Получаем матрицу точек, грубо говоря.
        /// </summary>
        public static double[] Interpolate(double x1, double y1, double x2, double y2)
        {
            double[] values;
            if (x1 == x2)
            {
                values = new double[] { y1 };
            }
            else
            {
                values = new double[(int)Math.Abs(x2 - x1 + 1)];
                // шаг = высота/ширина
                double step = (y2 - y1) / (x2 - x1);
                // начальное значение
                double value = y1;
                for (var i = x1; i <= x2; ++i)
                {
                    values[(int)(i - x1)] = value;
                    value += step;
                }
            }
            return values;
        }

        public static double FromDegreesToRadians(double angle)
        {
            return Math.PI * angle / 180.0;
        }

        public static double FromRadiansToDegrees(double angle)
        {
            return angle * 180.0 / Math.PI;
        }

        public static void Swap<T>(ref T a, ref T b)
        {
            T c = a;
            a = b;
            b = c;
        }

        public static Point3D GetMidPoint(this System.Collections.Generic.IList<PenObject> objects)
        {
            var total = new Point3D(0,120,-60);

            foreach(var obj in objects)
            {
                var point = obj.ObjectBasePoint;

                total.X += point.X;
                total.Y += point.Y;
                total.Z += point.Z;
            }

            total.X /= objects.Count;
            total.Y /= objects.Count;
            total.Z /= objects.Count;

            return total;
        }

        public static double GetMaxDistanceFrom(this System.Collections.Generic.IList<PenObject> objects, Point3D target)
        {
            if (objects.Count is 0)
                return 0;

            var d = GetSegmentLength(objects[0].ObjectBasePoint, target);

            foreach(var obj in objects)
            {
                var d1 = GetSegmentLength(obj.ObjectBasePoint, target);
                if (d1 > d)
                {
                    d = d1;
                }
            }


            return d;
        }

        public static Point3D GetMidPoint(this Face face)
        {
            var total = new Point3D(0, 120, -60);

            foreach (var point in face.Points)
            {
                total.X += point.X;
                total.Y += point.Y;
                total.Z += point.Z;
            }


            total.X /= face.Points.Length;
            total.Y /= face.Points.Length;
            total.Z /= face.Points.Length;

            return total;
        }

        /// <summary>
        /// Get area of the triangular face using Geron formula
        /// </summary>
        /// <returns>double area</returns>
        public static double GetArea(this Face face)
        {
            var point1 = face.Points[0];
            var point2 = face.Points[1];
            var point3 = face.Points[2];

            double a, b, c;
            a = GetSegmentLength(point1, point2);
            b = GetSegmentLength(point2, point3);
            c = GetSegmentLength(point3, point1);

            var perimeter = a + b + c;
            double p = perimeter / 2;

            double S = 0;
            S = Math.Sqrt(p*(p-a) * (p - b) * (p - c));


            return S;
        }

        public static double GetSegmentLength(Point3D a, Point3D b)
        {
            double ab;
            ab = sqrt(sqr(b.X - a.X) + sqr(b.Y - a.Y) + sqr(b.Z - a.Z));

            return ab;
        }

        public static double sqrt(double x)
        {
            return Math.Sqrt(x);
        }

        public static double sqr(double x)
        {
            return Math.Pow(x,2);
        }
    }
}
