using System;
using System.Collections.Generic;
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
            string filePath = "shapes.txt";
            List<Shape> shapes = ReadShapesFromFile(filePath);

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
            }
        }

        static List<Shape> ReadShapesFromFile(string filePath)
        {
            List<Shape> shapes = new List<Shape>();

            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    Shape shape = Shape.CreateShape(line);
                    shapes.Add(shape);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
            }

            return shapes;
        }
    }
}
