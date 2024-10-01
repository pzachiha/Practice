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
        protected static double ParseCoordinate(string coordinate)
        {
            if (!double.TryParse(coordinate, out double result))
            {
                throw new ArgumentException("Неверный формат координат");
            }
            return result;
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
        public static Shape CreateShape(string description)
        {
            string[] parts = description.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string type = parts[0];

            Shape shape;
            switch (type)
            {
                case "Point":
                    shape = new Point
                    {
                        X = Shape.ParseCoordinate(parts[1]),
                        Y = Shape.ParseCoordinate(parts[2]),
                        Color = Shape.ParseColor(parts[3])
                    };
                    break;
                case "Circle":
                    shape = new Circle
                    {
                        X = Shape.ParseCoordinate(parts[1]),
                        Y = Shape.ParseCoordinate(parts[2]),
                        Color = Shape.ParseColor(parts[3]),
                        Radius = Shape.ParseCoordinate(parts[4])
                    };
                    break;
                case "Square":
                    shape = new Square
                    {
                        X = Shape.ParseCoordinate(parts[1]),
                        Y = Shape.ParseCoordinate(parts[2]),
                        Color = Shape.ParseColor(parts[3]),
                        SideLength = Shape.ParseCoordinate(parts[4])
                    };
                    break;
                default:
                    throw new ArgumentException($"Неизвестный тип объекта: {type}");
            }

            return shape;
        }
    }
}

