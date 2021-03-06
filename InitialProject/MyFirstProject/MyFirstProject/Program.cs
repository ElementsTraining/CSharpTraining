﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using MySecondProject;
using MyFirstProject;
using MyThirdProject;

namespace MyFirstProject
{
    /// <summary>
    /// This is the generally class for any shape
    /// </summary>
    public abstract class Shape
    {
        public double width { get; set; }
        public double height { get; set; }
        /// <summary>
        /// This method call the calculation Area Method
        /// </summary>
        public void showArea()
        {
            Console.WriteLine("Area: {0} with the following Dimensions\n\twidth: {1} \n\tand \n\theight: {2}", this.calculateArea(), this.width, this.height);
        }
        public abstract double calculateArea();
    }

    /// <summary>
    /// this class implements Shape as a Rectangle
    /// </summary>
    class Rectangle : Shape
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

    /// <summary>
    /// This class implements Shape as a Square
    /// </summary>
    public class Square : Shape
    {
        public Square(double side)
        {
            this.height = this.width = side;
        }

        /// <summary>
        /// this method calculates the square area.
        /// </summary>
        /// <returns></returns>
        public override double calculateArea()
        {
            double area = width * height;
            return area;
        }
    }
}


/// <summary>
/// this is the executable class
/// </summary>
public class ExecutionRectangle
{
    public static void threadMethodB()
    {
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("Thread B");
        }
    }

    public static void threadMethodA()
    {
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("Thread A");
        }
    }

    private static void threadMethodC(object obj)
    {
        Thread.Sleep(1000);
        DataSctructure ds = new DataSctructure();
        Console.WriteLine(ds.dictionary.ToString());
    }

    public static void Main(string[] args)
    {
        Shape rectangle = new Rectangle(2, 4);
        rectangle.showArea();

        Shape square = new Square(2);
        square.showArea();
        
        Console.WriteLine();
        SecondClass sc = new SecondClass();
        Console.WriteLine();

        Thread tdA = new Thread(threadMethodA);
        tdA.Start();

        Thread tdB = new Thread(threadMethodB);
        tdB.Start();

        Thread tdC = new Thread(threadMethodC);
        tdC.Start();

        Console.WriteLine("Hit {0} to exit the program.", "[ENTER]");
        Console.ReadKey();
    }
}
