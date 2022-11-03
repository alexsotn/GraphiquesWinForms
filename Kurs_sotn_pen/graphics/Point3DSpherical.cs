using System;

	namespace Kurs_sotn_pen
{
    [Serializable]
    public class Point3DSpherical : Point3D
    {
        public double Radius { get; set; } // polar radius (Sphere.radius)
        public double Theta { get; private set; } // bend angle

        public double Phi { get; private set; } // rotation angle

        public void SetTheta(double value)
        {
            Theta = Math.Max(value, 0);
            UpdateDecart();
        }

        public void SetPhi(double value)
        {
            Phi = value;
            UpdateDecart(false);
        }

        public Point3DSpherical(double radius, double theta, double phi) : base(0, 0, 0)
        {
            Radius = radius;
            Theta = Math.Max(Theta, 0);
            Phi = phi;
            UpdateDecart();
        }

        /// <summary>
        /// Updating Decart coordinates
        /// </summary>
        /// <param name="updateY"></param>
        private void UpdateDecart(bool updateY = true)
        {
            X = Radius * Math.Sin(Theta) * Math.Cos(Phi);
            if (updateY)
            {
                Y = Radius * Math.Cos(Theta);
            }
            Z = Radius * Math.Sin(Theta) * Math.Sin(Phi);
        }

        /// <summary>
        /// Updating "Spherical coordinates"
        /// </summary>
        private void UpdateSpherical()
        {
            Radius = Math.Sqrt(X * X + Y * Y + Z * Z);
            Theta = Math.Max(Math.Acos(Y / Radius), 0);
            Phi = Math.Atan(Z / X);
        }

        public Point3DSpherical(Point3D point) : base(point)
        {
            Set(point.X, point.Y, point.Z);
        }

        public override void Add(double dx, double dy, double dz)
        {
            base.Add(dx, dy, dz);
            UpdateSpherical();
        }

        public virtual void Set(Point3D point)
        {
            Set(point.X, point.Y, point.Z);
        }

        public override void Set(double x, double y, double z)
        {
            base.Set(x, y, z);
            UpdateSpherical();
            if (X < 0)
            {
                Phi = Math.PI + Phi;
            }
            else if (Z < 0)
            {
                Phi = 2 * Math.PI + Phi;
            }
        }
    }
}
