using System;
using System.Drawing;

	namespace Kurs_sotn_pen
{
    [Serializable]
    public class PenObject : SceneObject
    {
        public int Control = 0; //Длинна ручки 

        public int SupRadius = 0;//диаметр ручки

        public int numericUpDown1 = 0;//размер всей подставки
      
        public int numericUpDown2 = 1;//количество колец на ручке

        public int numericUpDown3 = 1;//Количество держателей для ручки 


        public int numericUpDown4 = 0; //Высота середины подставки 

        public int numericUpDown5 = 0; // Диаметр сферы на кнопке ручки

        public int numericUpDown6 = 0; //Длина середины подставки


        public int numericUpDown7 = 0; // Размер стержня ручки

        public int numericUpDown8 = 0; // Размер основания подставки


       
        

        public PenObject() { }

        public PenObject(string name) : base(name)
        {
            UpdateObject();
        }

        public void UpdateObject()
        {
            Primitives.Clear();

          
            //Основание ручки (цилиндр) 

            var ob1= new PrimitiveWithName(
              new Cylinder(new Point3D(0, numericUpDown4 + 150, 20), SupRadius + 10, Control+120,  20, Color.DimGray),
              "Object", 90
              );
            Primitives.Add(ob1);


            //острие чучки
            var ob2=new PrimitiveWithName(
      new Sphere(new Point3D(0, numericUpDown4 + 150, 20), numericUpDown7+ 10, 10, Color.DimGray),
      "Object", 90
      );
            Primitives.Add(ob2);

            if (numericUpDown3 > 0)
            {
                //Треугольники внизу

                var ob3 = new PrimitiveWithName(
                new BoxTriangleBack(new Point3D(5, numericUpDown4 + 140, -80), 10, 5, 10, Color.DimGray),
                  "Object", 90
                  );
                Primitives.Add(ob3);


                var ob4 = new PrimitiveWithName(
                 new BoxTriangle(new Point3D(-5, numericUpDown4 + 140, -80), 10, 5, 10, Color.DimGray),
                 "Object", 90
                 );
                Primitives.Add(ob4);

                //Треугольники вверху

                var ob5 = new PrimitiveWithName(
                  new BoxTriangle(new Point3D(-5, numericUpDown4 + 140, -10), 10, 5, 10, Color.DimGray),
                 "Object", 90
                 );
                Primitives.Add(ob5);

                var ob6 = new PrimitiveWithName(
                 new BoxTriangleBack(new Point3D(5, numericUpDown4 + 140, -10), 10, 5, 10, Color.DimGray),
                 "Object", 90
                 );
                Primitives.Add(ob6);

                if (numericUpDown3 > 1)
                {
                    //доп подставка 
                    var ob17 = new PrimitiveWithName(
               new BoxTriangleBack(new Point3D(5, numericUpDown4 + 140, -50), 10, 5, 10, Color.DimGray),
                 "Object", 90
                 );
                    Primitives.Add(ob17);

                    var ob18 = new PrimitiveWithName(
               new BoxTriangle(new Point3D(-5, numericUpDown4 + 140, -50), 10, 5, 10, Color.DimGray),
                 "Object", 90
                 );
                    Primitives.Add(ob18);

                    if (numericUpDown3 > 2)
                    {
                        var ob19 = new PrimitiveWithName(
                          new BoxTriangle(new Point3D(-5, numericUpDown4 + 140, -30), 10, 5, 10, Color.DimGray),
                       "Object", 90
                       );
                        Primitives.Add(ob19);

                        var ob20 = new PrimitiveWithName(
                       new BoxTriangleBack(new Point3D(5, numericUpDown4 + 140, -30), 10, 5, 10, Color.DimGray),
                         "Object", 90
                     );
                        Primitives.Add(ob20);

                    }

                }


            }
            if (numericUpDown2>0) 
            {
                //тор 1 


                var tor = new PrimitiveWithName(
            new Spherepol(new Point3D(0, numericUpDown4 + 150, -75), SupRadius + 11, 30, Color.DimGray),
            "tor", 90
            );

                Primitives.Add(tor);

                //тор2

                var tor1 = new PrimitiveWithName(
               new Spherepol(new Point3D(0, numericUpDown4 + 150, -65), SupRadius + 11, 30, Color.DimGray),
               "tor", 90
               );

                Primitives.Add(tor1);

                if (numericUpDown2 > 1)
                {
                    var tor2 = new PrimitiveWithName(
                  new Spherepol(new Point3D(0, numericUpDown4 + 150, -55), SupRadius + 11, 30, Color.DimGray),
                  "tor", 90
                  );

                    Primitives.Add(tor2);

                    if (numericUpDown2 > 2)
                    {
                        var tor3 = new PrimitiveWithName(
                         new Spherepol(new Point3D(0, numericUpDown4 + 150, -45), SupRadius + 11, 30, Color.DimGray),
                       "tor", 90
                      );
                         Primitives.Add(tor3);
                    }
                }

            }
            //Сфера
            var ob7=new PrimitiveWithName(
           new Sphere(new Point3D(0, numericUpDown4 + 150, -100), numericUpDown5+ 9, 30, Color.DimGray),
           "tor", 90
           );

            Primitives.Add(ob7);

            //Середина додставки 

            var ob8 = new PrimitiveWithName(
          new Box(new Point3D(0, 109, -48), numericUpDown1 + 20, numericUpDown4+ 30, numericUpDown1 + numericUpDown6 + 75, Color.DimGray),
          "tor"
          );

            Primitives.Add(ob8);
            // Основание 
          
            var ob9 = new PrimitiveWithName(
          new Box(new Point3D(0, 105,  -10), numericUpDown8+ numericUpDown1 + 50, numericUpDown8 + 75, numericUpDown8 + numericUpDown1 + 10, Color.DimGray),
          "tor",90
          );

            Primitives.Add(ob9);


            //Пирамида
       
            var ob10 = new PrimitiveWithName(
           new Sphere(new Point3D(17, 110, -75), 8, 4, Color.DimGray),
           "tor", 90
           );

            Primitives.Add(ob10);

            //цилиндр
         
            var ob11= new PrimitiveWithName(
          new Cylinder(new Point3D(18, 110, -55), 7, 6, 8, Color.DimGray),
          "tor"
          );

            Primitives.Add(ob11);
            //Сфера на цилиндре 
         
            var ob12= new PrimitiveWithName(
          new Sphere(new Point3D(18, 115, -55), 6, 20, Color.DimGray),
          "tor"
          );

            Primitives.Add(ob12);

            //конус
        
            var ob13= new PrimitiveWithName(
         new Sphere(new Point3D(18, 110, -35), 7, 11, Color.DimGray),
         "tor"
         );
            
            Primitives.Add(ob13);

            //Сфера на конусе
            
            var ob14= new PrimitiveWithName(
          new Sphere(new Point3D(18, 115, -35), 3, 20, Color.DimGray),
          "tor"
          );

            Primitives.Add(ob14);

            //Многоугольный конус 
            var ob15= new PrimitiveWithName(
             new Sphere(new Point3D(18, 110, -18), 7, 6, Color.DimGray),
             "tor"
             );

            Primitives.Add(ob15);
           
            //сфера на конусе
            
            var ob16= new PrimitiveWithName(
         new Sphere(new Point3D(18, 115, -18), 3, 20, Color.DimGray),
         "tor"
         );

            Primitives.Add(ob16);



        }
    }
}
