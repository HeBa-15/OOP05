using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.Sealed
{
    internal class ImmutableString
    {
        private readonly string value;
        public string Value
        {
            get { return value; }
        }
        public ImmutableString(string Value)
        {
            this.value = Value;
        }
    }
}
