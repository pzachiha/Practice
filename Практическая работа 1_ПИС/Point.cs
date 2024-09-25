using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа_1_ПИС
{
    internal class Point:Shape
    {
        public override string ToString()
        {
            return $"X: {X}, Y: {Y}, Color: {Color}";
        }
    }
}
