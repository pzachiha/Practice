using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа_1_ПИС
{
    public class ErrorHandler
    {
        public static void HandleException(Action action)
        {
            try
            {
                action();
            }
            catch (FileNotFoundException fileNotFound)
            {
                Console.WriteLine($"Файл не найден: {fileNotFound.Message}");
            }
            catch (ArgumentException argumentException)
            {
                Console.WriteLine($"Неверный аргумент: {argumentException.Message}");
            }
            catch (FormatException formatException)
            {
                Console.WriteLine($"Ошибка формата данных: {formatException.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
