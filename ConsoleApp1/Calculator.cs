using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Calculator : ICalculator
    {
        public int A { get; set; }
        public override string ToString() => "Simple calculator";
    }
}
