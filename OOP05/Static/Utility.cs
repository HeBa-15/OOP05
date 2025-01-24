using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.Static
{
    // static Class
    // is a just Container for static members [Attributes, Property, Constructor, Method]
    // and constants
    // You can't create an object from this class
    // No Inheritance for this class
    internal static class Utility
    {
        // Static Constructor [Max only One per Class]
        // You can't specify Access Modifiers or parameters for the static constructor
        // Will be Called just only one time per class lifetime before the first usage of the class
        /// the Usages of the Class as Following:
        /// 1. Create object from the class or another class inherited from it
        /// 2. Call Static Property
        /// 3. Call Static Method
        static Utility()
        {
            // pi = 3.14;
        }

        // Class Member Method : Static Method
        public static double CmToInch(double cm)
        {
            return cm / 2.54;
        }
        /// 1. Class Member Attribute: Static Attribute
        /// private static readonly double pi = default;
        /// CLR will initialize each and every static attribute with its datatype default value before the first usage of the class
        // 2. Constant

        private const double pi = 3.14;
        // Class Member Property : Static Property: [Must deal with on of the following]:
        /// 1. Static Attribute
        /// 2. Constant
        public static double PI
        {
            get { return pi; }
        }
        // Class member method: Static method
        public static double CalcCircleArea(double Radius)
        {
            return PI * Radius * Radius;
        }
    }
}
