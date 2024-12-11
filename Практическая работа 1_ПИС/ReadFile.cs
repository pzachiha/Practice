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
            ErrorHandler.HandleException(() =>
            {
                string[] lines = File.ReadAllLines(filePath);
                PopulateShapes(shapes, lines);
            });
            return shapes;
        }

        private static void PopulateShapes(List<Shape> shapes, string[] lines)
        {
            foreach (string line in lines)
            {
                ErrorHandler.HandleException(() =>
                {
                Shape shape = ShapeFactory.CreateShape(line);
                shapes.Add(shape);
                });
            }
        }
    }
}
