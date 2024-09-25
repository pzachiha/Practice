using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа_1_ПИС
{
    internal class Circle:Shape
    {
        public double Radius { get; set; }

        public override string ToString()
        {
            return $"X: {X}, Y: {Y}, Radius: {Radius}, Color: {Color}";
        }

    }
}
