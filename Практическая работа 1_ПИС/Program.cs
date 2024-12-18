using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Практическая_работа_1_ПИС
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            ErrorHandler.HandleException(() =>
            {
                string tryString = "Point 5,5 7,7 \"yellow\"";
                Console.WriteLine(ShapeFactory.CreateShape(tryString));
            });
            ErrorHandler.HandleException(() =>
            {
                string filePath = "shapes.txt";
                List<Shape> shapes = ReadFile.ReadShapesFromFile(filePath);
                foreach (var shape in shapes)
                {
                    Console.WriteLine(shape);
                }
            });
            Circle circle = new Circle();
            ErrorHandler.HandleException(() =>
            {
                circle.ReadFromLine(null);
            });
        }
    }
}
