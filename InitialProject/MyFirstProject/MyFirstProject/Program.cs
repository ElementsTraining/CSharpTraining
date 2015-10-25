using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public abstract class Form
    {
        public double width { get; set; }
        public double height { get; set; }
        public abstract double calculateArea();
    }

    class Rectangle : Form
    {
        
        public override double calculateArea()
        {
            double area = width * height;
            return area;
        }

        public Rectangle( double width, double height)
        {
            this.height = height;
            this.width = width;
        }

    }

    public class Square : Form
    {
        public Square(double side)
        {
            this.height = this.width = side;
        }

        public override double calculateArea()
        {
            double area = width * height;
            return area;
        }
    }

    public class ExecutionRectangle
    {
        static void Main(string[] args)
        {
            Form rectangle = new Rectangle(2,4);
            Console.WriteLine("Rectangle Area: {0} with the following Dimensions\n\twidth: {1} \n\tand \n\theight: {2}",rectangle.calculateArea(),rectangle.width, rectangle.height);

            Form square = new Square(2);
            Console.WriteLine("Square Area:  {0} with the following Dimensions\n\twidth: {1} \n\tand \n\theight: {2} ", square.calculateArea(), square.width, square.height);

            Console.Write("Hit {0} to exit the program.", "[ENTER]");
            Console.ReadKey();
        }
    }
}
