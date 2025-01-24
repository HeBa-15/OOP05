using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.Sealed
{
    class Parent
    {
        public virtual int Salary { get; set; }
        public virtual void Print()
        {
            Console.WriteLine("I am Base");
        }
    }
    class Child : Parent
    {
        // Sealed Property
        public sealed override int Salary
        {
            get { return Salary; }
            set { Salary = value < 5000 ? 5000 : value; }
        }
        // Sealed Method
        public override void Print()
        {
            Console.WriteLine("I am Derived");
        }
    }
    // Sealed Class
    sealed class GrandChild : Child
    {
        public new int Salary
        {
            get { return Salary; }
            set { Salary = value < 5000 ? 5000 : value; }
        }
        public new void Print()
        {
            Console.WriteLine("I am Derived");
        }
    }
}
