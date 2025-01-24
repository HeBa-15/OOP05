using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.Partial
{
   // Developer 02
    internal partial class Employee
    {
        public string? Address { get; set; }

        public partial int DoSomeCode()
        {
            return 10;
        }
    }
}
