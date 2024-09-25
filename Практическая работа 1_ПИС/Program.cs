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
            Console.WriteLine("Введите строку с описанием свойств двумерной точки:");
            string input = "5,5 6,6 \"green\"";
            Point point = Point.ParseProperties(input);
            Console.WriteLine(point);
        }
    }
}
