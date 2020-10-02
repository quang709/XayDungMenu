using System;
using System.Collections.Generic;
using System.Text;

namespace Xây_dựng_menu
{
    public class Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Side { get; set; }
        public double Radius { get; set; }
        public double AreaRectangle(double Length, double Width)
        {
            return Length * Width;
        }
        public double PerimeterRectangle(double Length, double Width)
        {
            return (Length + Width) * 2;
        }
        public double AreaSquare(double Side)
        {
            return Side * Side;
        }
        public double PerimeterSquare(double Side)
        {
            return Side * 4;
        }
        public double AreaCircle(double Radius)
        {
            return Radius * Radius * Math.PI;
        }
        public double PerimeterCircle(double Radius)
        {
            return 2 * Radius * Math.PI;
        }
    }
}