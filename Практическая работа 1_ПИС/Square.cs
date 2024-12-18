using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа_1_ПИС
{
    public class Square:Shape
    {
        public double SideLength { get; set; }
        public override void ReadFromLine(string line)
        {
            if (line == null)
            {
                throw new ArgumentNullException(nameof(line), "Параметр 'line' не может быть null");
            }
            string[] parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            X = ParseDouble(parts[1]);
            Y = ParseDouble(parts[2]);
            Color = ParseColor(parts[3]);
            SideLength = ParseDouble(parts[4]);
        }
        public override string ToString()
        {
            return $"Square: X: {X}, Y: {Y}, SideLength: {SideLength}, Color: {Color}";
        }
    }
}
