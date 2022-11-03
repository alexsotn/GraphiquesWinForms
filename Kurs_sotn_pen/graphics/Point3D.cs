using System;

	namespace Kurs_sotn_pen
{
    [Serializable]
    public class Point3D
    {
        /// <summary>
        /// Decart coordinates
        /// </summary>
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public double Length { get { return (float)Math.Sqrt(X * X + Y * Y + Z * Z); } }

        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Point3D(Point3D point)
        {
            X = point.X;
            Y = point.Y;
            Z = point.Z;
        }

        public Point3D(Vector3D vector)
        {
            X = vector.X;
            Y = vector.Y;
            Z = vector.Z;
        }

        public virtual void Add(double x, double y, double z)
        {
            X += x;
            Y += y;
            Z += z;
        }

        public virtual void Add(Point3D point)
        {
            X += point.X;
            Y += point.Y;
            Z += point.Z;
        }

        public virtual void Set(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Matrix GetProjectiveCoordinates()
        {
            double[] result = new double[4];
            result[0] = X;
            result[1] = Y;
            result[2] = Z;
            result[3] = 1.0;
            return new Matrix(result);
        }

        public Point3D Clone()
        {
            return new Point3D(this);
        }
    }
}
