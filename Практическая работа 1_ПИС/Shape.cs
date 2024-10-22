using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
        protected static double ParseDouble(string parameter)
        {
            return double.Parse(parameter);
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
        public virtual void ReadFromLine(string line)
        {
            string[] parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            X = ParseDouble(parts[1]);
            Y = ParseDouble(parts[2]);
            Color = ParseColor(parts[3]);
        }
        public static Shape CreateShape(string description)
        {
            string[] parts = description.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Shape shape;
            switch (parts[0])
            {
                case "Point":
                    shape = new Point();
                    break;
                case "Circle":
                    shape = new Circle();
                    break;
                case "Square":
                    shape = new Square();
                    break;
                default: throw new ArgumentException($"Неизвестный тип объекта: {parts[0]}");
            }
            shape.ReadFromLine(description);
            return shape;
        }
    }
}

