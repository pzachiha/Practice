using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа_1_ПИС
{
    public abstract class Shape
    {
        public double X { get; set; }
        public double Y { get; set; }
        public string Color { get; set; }
        public abstract override string ToString();
        protected static double ParseDouble(string coordinate)
        {
            return double.Parse(coordinate);
        }
        protected static string ParseColor(string color)
        {
            string[] validColors = { "green", "blue", "red" };
            string colorWithoutQuotes = color.Trim('"');

            if (!validColors.Contains(colorWithoutQuotes))
            {
                throw new ArgumentException("Недопустимый цвет");
            }

            return colorWithoutQuotes;
        }
        public static T CreateShapeAtPosition<T>(double x, double y, string color) where T : Shape, new()
        {
            return new T() { X = x, Y = y, Color = color };
        }
        public static T ParseAndCreateShape<T>(string x, string y, string color) where T : Shape, new()
        {
            return CreateShapeAtPosition<T>(ParseDouble(x), ParseDouble(y), ParseColor(color));
        }
        public static Shape CreateShape(string description)
        {
            string[] parts = description.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            switch (parts[0])
            {
                case "Point": return ParseAndCreateShape<Point>(parts[1], parts[2], parts[3]);
                case "Circle":
                    return ParseAndCreateShape<Circle>(parts[1], parts[2], parts[3]).SetRadius(ParseDouble(parts[4]));
                case "Square":
                    return ParseAndCreateShape<Square>(parts[1], parts[2], parts[3]).SetSideLength(ParseDouble(parts[4]));
                default: throw new ArgumentException($"Неизвестный тип объекта: {parts[0]}");
            }
        }
    }
}

