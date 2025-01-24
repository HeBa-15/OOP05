using OOP05.Sealed;

namespace OOP05
{
    internal class Program
    {


        static void CalcPayment(PaymentProcessor processor)
        {
            processor.ProcessPayment(100);
        }


        static void Main(string[] args)
        {
            #region Abstraction [Abstract Class, Abstract Method, Abstract Property]

            /// Shape shape;
            /// 
            ///  //Shape shape = new Shape();
            ///  //shape.CalcArea();
            ///  
            /// shape = new Rect() { Dim01 = 10 , Dim02 = 20};
            /// decimal rectArea = shape.CalcArea();
            /// 
            /// decimal rectPeri = shape.Perimeter;
            /// 
            /// Console.WriteLine($"Rect Peri = {rectPeri}");
            /// Console.WriteLine($"Rect Area = : {rectArea}");
            ///
            /// shape  = new Sqaure(20);
            /// decimal squarePeri = shape.Perimeter;
            /// decimal squareArea = shape.CalcArea();
            ///
            /// Console.WriteLine($"square Peri = {squarePeri}");
            /// Console.WriteLine($"sqaure Area = : {squareArea}");
            ///
            ///
            ///shape = new Circle(20);
            ///decimal circleperi = shape.Perimeter;
            ///decimal circlleArea = shape.CalcArea();
            ///
            ///Console.WriteLine($"Circle Peri = {circleperi}");
            ///Console.WriteLine($"Circle Area = : {circlleArea}"); 

            #endregion

            #region Static [Class, Atrribute, Property, Constructor, Method] and Const

            //Utility U01 = new Utility(1, 2);
            //Utility U02 = new Utility(5, 20);

            // The result of calling this method will not be different by the difference of the Object

            /// Console.WriteLine(Utility.CmToInch(23));
            /// Console.WriteLine(Utility.CmToInch(251));

            // Console.WriteLine($"Circle Area = {Utility.CalcCircleArea(10)}");
            // Console.WriteLine($"Circle Area = {Utility.CalcCircleArea(10)}");

            #endregion



            #region Sealed [Class, Method, Property]

            //ImmutableString str = new ImmutableString("Ahmed");
            //str = new ImmutableString("Mohamed"); 

            #endregion


            #region Partial [Class, struct, Interface, Method]

            //Employee employee = new Employee()
            //{
            //    Id = 1234,
            //    Name = "Ahmed",
            //    Age = 23,
            //    Address = "Alexandria"
            //}; 

            #endregion



        }
    }
}