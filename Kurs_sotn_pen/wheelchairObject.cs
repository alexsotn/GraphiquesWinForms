using System;
using System.Drawing;

namespace wheelchair
{
    [Serializable]
    public class wheelchairObject : SceneObject
    {
        public int Control = 6;//количество торов
        public int SupRadius = 2;//радиус сферы на крестовине
        public int numericUpDown1 = 20;//сторона ромба крестовины
        public int numericUpDown2 = 3;//толщина крестовины
        public int numericUpDown3 = 20;//сторона ромба сечения лезвия
        public int numericUpDown4 = 180; //длина лезвия
        public int numericUpDown5 = 3; //сторона куба на крестовине
        public int numericUpDown6 = 35; //длина рукояти
        public int numericUpDown7 = 4; //радиус рукояти
        public int numericUpDown8 = 3; //Угол сужения лезвия
        public int numericUpDown9 = 5; //радиус сечения торов на рукояти

        public wheelchairObject() { }

        public wheelchairObject(string name) : base(name)
        {
            UpdateObject();
        }

        public void UpdateObject()
        {
            Primitives.Clear();

            var navershie = new PrimitiveWithName(
            new Sphere(new Point3D(0, 155, numericUpDown6 - 10), 7, 11, Color.Black),/*навершие  */
            "navershie", 90
            );
            Primitives.Add(navershie);

            var rukoat = new PrimitiveWithName(
                   new Cylinder(new Point3D(0, 155, numericUpDown6 - 11), numericUpDown7, numericUpDown6, 20, Color.Brown),/*рукоять*/
                   "rukoat", 90
                   );
            Primitives.Add(rukoat);

            var krestovina = new PrimitiveWithName(
                   new Cylinder(new Point3D(0, 155, -9), numericUpDown1, numericUpDown2, 4, Color.Brown),/*крестовина*/
                   "krestovina", 90
                   );
            Primitives.Add(krestovina);

            var kub = new PrimitiveWithName(
           new Box(new Point3D(0, 154+ numericUpDown1, -10), numericUpDown5, numericUpDown5, numericUpDown5, Color.Brown), /*куб*/
           "kub"
           );
            Primitives.Add(kub);

            var kub2 = new PrimitiveWithName(
           new Box(new Point3D(0, 153- numericUpDown1, -10), numericUpDown5, numericUpDown5, numericUpDown5, Color.Brown), /*куб*/
           "kub2"
           );
            Primitives.Add(kub2);

            var sphere = new PrimitiveWithName(
            new Sphere(new Point3D(0, 158 + numericUpDown1, -10), SupRadius - 0.5, 30, Color.Brown),/*сфера  */
            "sphere"
            );
            Primitives.Add(sphere);

            var sphere2 = new PrimitiveWithName(
            new Sphere(new Point3D(0, 152 - numericUpDown1, -10), SupRadius - 0.5, 30, Color.Brown),/*сфера  */
            "sphere2"
            );
            Primitives.Add(sphere2);

            var lezvie = new PrimitiveWithName(
                   new BoxTriangle(new Point3D(1, 155, -10), numericUpDown8-1, numericUpDown4, numericUpDown3, Color.DarkSlateGray),/*лезвие*/
                   "lezvie", 90
                   );
            Primitives.Add(lezvie);

            var lezvie2 = new PrimitiveWithName(
                   new BoxTriangleBack(new Point3D(-1, 155, -10), numericUpDown8-1, numericUpDown4, numericUpDown3, Color.DarkSlateGray),/*лезвие*/
                   "lezvie2", 90
                   );
            Primitives.Add(lezvie2);

            var ostrie = new PrimitiveWithName(
                   new BoxTriangleBackostr(new Point3D(-1, 155, -numericUpDown4 - 10), numericUpDown8-1, 40, numericUpDown3, Color.DarkSlateGray),/*острие*/
                   "ostrie", 90
                   );
            Primitives.Add(ostrie);

            var ostrie2 = new PrimitiveWithName(
                   new BoxTriangleosrt(new Point3D(1, 155, -numericUpDown4 - 10), numericUpDown8-1, 40, numericUpDown3, Color.DarkSlateGray),/*острие*/
                   "ostrie2", 90
                   );
            Primitives.Add(ostrie2);



            if (Control > 0)
            {
                var tor = new PrimitiveWithName(
                new Spherepol(new Point3D(0, 155, 20), numericUpDown9, 30, Color.Maroon),
                "tor", 90
                );
                Primitives.Add(tor);

                if (Control > 1)
                {

                    var tor1 = new PrimitiveWithName(
                    new Spherepol(new Point3D(0, 155, 15), numericUpDown9, 30, Color.Maroon),
                    "tor1", 90
                    );
                    Primitives.Add(tor1);



                    if (Control > 2)
                    {
                        var tor2 = new PrimitiveWithName(
                        new Spherepol(new Point3D(0, 155, 10), numericUpDown9, 30, Color.Maroon),
                        "tor2", 90
                        );
                        Primitives.Add(tor2);



                        if (Control > 3)
                        {
                            var tor3 = new PrimitiveWithName(
                             new Spherepol(new Point3D(0, 155, 5), numericUpDown9, 30, Color.Maroon),
                             "tor3", 90
                             );
                            Primitives.Add(tor3);


                            if (Control > 4)
                            {
                                var tor4 = new PrimitiveWithName(
                                 new Spherepol(new Point3D(0, 155, 0), numericUpDown9, 30, Color.Maroon),
                                 "tor4", 90
                                 );
                                Primitives.Add(tor4);

                                if (Control > 5)
                                {

                                    var tor5 = new PrimitiveWithName(
                                    new Spherepol(new Point3D(0, 155, -5), numericUpDown9, 30, Color.Maroon),
                                    "tor5", 90
                                    );
                                    Primitives.Add(tor5);

                                    if (Control > 6)
                                    {

                                        var tor6 = new PrimitiveWithName(
                                        new Spherepol(new Point3D(0, 155, -10), numericUpDown9, 30, Color.Maroon),
                                        "tor6", 90
                                        );
                                        Primitives.Add(tor6);

                                    }
                                }
                            }
                        }
                    }


                }
            }
        }
    }
}
