using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа_1_ПИС
{
    public class ShapeFactory
    {
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
                default:
                    Console.WriteLine($"Неизвестный тип объекта: {parts[0]}");
                    return null;
            }
            shape.ReadFromLine(description);
            return shape;
        }
    }
}
