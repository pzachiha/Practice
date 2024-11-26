using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Практическая_работа_1_ПИС;
namespace ModuleTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestCreateShape_Point()
        {
            string line = "Point 1 2 \"green\"";
            Shape shape = Shape.CreateShape(line);
            Assert.IsType<Point>(shape);
            Assert.Equal(1, shape.X);
            Assert.Equal(2, shape.Y);
            Assert.Equal("green", shape.Color);
        }

        [Fact]
        public void TestCreateShape_Circle()
        {
            string line = "Circle 1 2 \"blue\" 5";
            Shape shape = Shape.CreateShape(line);
            Assert.IsType<Circle>(shape);
            Circle circle = (Circle)shape;
            Assert.Equal(1.0, circle.X);
            Assert.Equal(2.0, circle.Y);
            Assert.Equal("blue", circle.Color);
            Assert.Equal(5.0, circle.Radius);
        }

        [Fact]
        public void TestCreateShape_Square()
        {
            string line = "Square 1,0 2,0 \"red\" 4,0";
            Shape shape = Shape.CreateShape(line);
            Assert.IsType<Square>(shape);
            Square square = (Square)shape;
            Assert.Equal(1.0, square.X);
            Assert.Equal(2.0, square.Y);
            Assert.Equal("red", square.Color);
            Assert.Equal(4.0, square.SideLength);
        }

        [Fact]
        public void TestCreateShape_InvalidColor()
        {
            string line = "Point 1,0 2,0 \"yellow\"";
            Assert.Throws<ArgumentException>(() => Shape.CreateShape(line));
        }

        [Fact]
        public void TestCreateShape_InvalidType()
        {
            string line = "Triangle 1,0 2,0 \"green\"";
            Assert.Throws<ArgumentException>(() => Shape.CreateShape(line));
        }

        [Fact]
        public void TestReadShapesFromFile_ValidFile()
        {
            string filePath = "shapes.txt";
            List<Shape> shapes = ReadFile.ReadShapesFromFile(filePath);
            Assert.Equal(3, shapes.Count);
        }

        [Fact]
        public void TestReadShapesFromFile_InvalidFile()
        {
            string filePath = "nothing.txt";
            List<Shape> shapes = ReadFile.ReadShapesFromFile(filePath);
            Assert.Empty(shapes);
        }
    }
}