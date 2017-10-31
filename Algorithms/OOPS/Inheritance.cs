using System;
namespace Algorithms.OOPS
{
    public class Inheritance
    {
        public Inheritance()
        {
        }

        //static void Main(string[] args)
        //{
        //    Rectangle rectangle = new Rectangle();
        //    rectangle.setHeight(5);
        //    rectangle.setWidth(7);
        //    Console.Write("Area of Rectangle {0}", rectangle.getArea());
        //}
    }

    public class Shape
    {
        public int width = 0;
        public int height = 0;

        public void setHeight(int height)
        {
            this.height = height;
        }


        public void setWidth(int width)
        {
            this.width = width;
        }
    }

    public class Rectangle : Shape
    {
        public int getArea()
        {
            return this.height * this.width;
        }
    }

}
