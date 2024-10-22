using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа_1_ПИС
{
    public class ReadFile
    {
        public static List<Shape> ReadShapesFromFile(string filePath)
        {
            List<Shape> shapes = new List<Shape>();
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                PopulateShapes(shapes, lines);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
            }
            return shapes;
        }

        private static void PopulateShapes(List<Shape> shapes, string[] lines)
        {
            foreach (string line in lines)
            {
                Shape shape = Shape.CreateShape(line);
                shapes.Add(shape);
            }
        }
    }
}
