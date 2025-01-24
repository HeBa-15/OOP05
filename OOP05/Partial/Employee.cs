using OOP05.Sealed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.Partial
{
    // Developer 01
    internal partial class Employee : Parent
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }
        // Partial Method
         partial void DoSomeCode();
        public void Test() 
        {
            DoSomeCode();
        }
    }
}
