using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа_1_ПИС
{
    internal class Square:Shape
    {
        public double SideLength { get; set; }
        public override string ToString()
        {
            return $"Square: X: {X}, Y: {Y}, SideLength: {SideLength}, Color: {Color}";
        }
    }
}
