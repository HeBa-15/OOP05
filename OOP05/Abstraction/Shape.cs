using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.Abstraction
{
    // Abstract CLass 
    // is a partial implementation for other classes.
    // is a container for common code [Fully implemented members, Abstract Members] Among many CLasses.
    // You can't create an Object from Abstracted CLass
    abstract class Shape
    {
        public decimal Dim01 { get; set; }
        public decimal Dim02 { get; set; }
        // abstract property = Virtual property without implementation
        public abstract decimal Perimeter { get; }
        // Abstract Method = Virtual Method without implementation
        public abstract decimal CalcArea();
    }
    abstract class RectBase : Shape
    {
        public override decimal CalcArea()
        {
            return Dim01 * Dim02;
        }
    }
    //concrete Class
    class Rect : RectBase
    {
        public override decimal Perimeter
        {
            get { return (Dim01 + Dim02) * 2; }

        }

    }
    // Concrete Class
    class Sqaure : RectBase
    {
        public Sqaure(int Dim)
        {
            this.Dim01 = this.Dim02 = Dim;
        }
        public override decimal Perimeter
        {
            get { return Dim01 * 4; }
        }

    }
    // concrete class
    class Circle : Shape
    {
        public Circle(decimal Radius)
        {
            this.Dim01 = this.Dim02 = Radius;
        }
        public override decimal Perimeter
        {
            get { return 2 * 3.14M * this.Dim01; }
        }
        public override decimal CalcArea()
        {
            return 3.14M * this.Dim01 * this.Dim01;
        }
    }
    class Parent
    {
        public virtual int Salary { get; set; }
        public virtual void print()
        {
            Console.WriteLine("Iam Parent");
        }
    }
    class Child : Parent
    {
        public override int Salary
        {
            get { return base.Salary; }
            set { base.Salary = value + 2000; }
        }
        public override void print()
        {
            Console.WriteLine("Iam Child");
        }
    }
}
