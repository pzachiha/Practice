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
            if (double.TryParse(parameter, out double result))
            {
                return result;
            }
            else
            {
                throw new ArgumentException("Ошибка c double");
            }
        }
        protected static string ParseColor(string color)
        {
            if (color == null)
            {
                throw new ArgumentNullException(nameof(color), "The 'color' parameter cannot be null.");
            }
            string[] validColors = { "green", "blue", "red" };
            string colorWithoutQuotes = color.Trim('"');

            if (validColors.Contains(colorWithoutQuotes))
            {
                return colorWithoutQuotes;
            }
            else
            {
                throw new ArgumentException("Ошибка с цветом");
            }
        }
        public virtual void ReadFromLine(string line)
        {
            {
                //if (line == null)
                //{
                //    throw new ArgumentNullException(nameof(line), "The 'line' parameter cannot be null.");
                //}
                string[] parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                X = ParseDouble(parts[1]);
                Y = ParseDouble(parts[2]);
                Color = ParseColor(parts[3]);
            }
        }
        
    }
}

