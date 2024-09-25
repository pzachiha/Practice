using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа_1_ПИС
{
    internal class Shape
    {
        public double X { get; set; }
        public double Y { get; set; }
        public string Color { get; set; }
        public override string ToString()
        {
            return $"X: {X}, Y: {Y}, Color: {Color}";
        }

        public static Shape ParseProperties(string description)
        {
            string[] parts = description.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length != 3)
            {
                throw new ArgumentException("Неверный формат описания");
            }

            if (!double.TryParse(parts[0], out double x) || !double.TryParse(parts[1], out double y))
            {
                throw new ArgumentException("Неверный формат координат");
            }

            string color = parts[2];

            if (color.StartsWith("\"") && color.EndsWith("\""))
            {
                color = color.Trim('"');
                if (color != "red" && color != "green" && color != "blue")
                {
                    throw new ArgumentException("Неверный формат цвета");
                }
            }
            else
            {
                throw new ArgumentException("Цвет должен быть заключен в кавычки");
            }

            return new Shape { X = x, Y = y, Color = color };
        }
    }
}

