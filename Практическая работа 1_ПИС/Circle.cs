using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа_1_ПИС
{
    public class Circle:Shape
    {
        public double Radius { get; set; }
        public override void ReadFromLine(string line)
        {
            string[] parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            X = ParseDouble(parts[1]);
            Y = ParseDouble(parts[2]);
            Color = ParseColor(parts[3]);
            Radius = ParseDouble(parts[4]);
        }

        public override string ToString()
        {
            return $"Circle: X: {X}, Y: {Y}, Radius: {Radius}, Color: {Color}";
        }

    }
}
