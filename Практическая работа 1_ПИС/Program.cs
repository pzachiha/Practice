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
            string tryString = "Point 6,6 7,7 \"green\"";
            Console.WriteLine(Shape.CreateShape(tryString));

            string filePath = "shapes.txt";
            List<Shape> shapes = ReadFile.ReadShapesFromFile(filePath);
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
            }
        }
    }
}
