using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.Geometric_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangle = new Triangle();

            triangle.Point1 = 1.6; //все данные (координаты) условные
            triangle.Point2 = 0.0;
            triangle.Point3 = 0.12;

            var rhombus = new Rhombus();

            rhombus.Point1 = 1.6; //все данные (координаты) условные
            rhombus.Point2 = 0.0;
            rhombus.Point3 = 0.12;
            rhombus.Point4 = -1.6;


            var square = new Square();

            square.Point1 = 0.1; //все данные (координаты) условные
            square.Point2 = 0.0;
            square.Point3 = 1.0;
            square.Point4 = 1.1;

            var rectangle = new Rectangle();

            rectangle.Point1 = 0.1; //все данные (координаты) условные
            rectangle.Point1 = 0.0;
            rectangle.Point3 = 2.0;
            rectangle.Point4 = 2.1;

            var octagon = new Octagon();

            octagon.Point1 = 0.0; //все данные (координаты) условные
            octagon.Point2 = 1.1;
            octagon.Point3 = 0.5;
            octagon.Point4 = 0.3;
            octagon.Point5 = 0.4;
            octagon.Point6 = 1.3;
            octagon.Point7 = 1.6;
            octagon.Point8 = 2.3;
        }
    }
}
