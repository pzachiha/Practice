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
            if (action == null)
            {
                throw new ArgumentNullException(nameof(action), "The 'action' parameter cannot be null.");
            }
            try
            {
                action();
            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine($"Ошибка аргумента: {argEx.Message}");
            }
            catch (FormatException formatEx)
            {
                Console.WriteLine($"Ошибка формата данных: {formatEx.Message}");
            }
            catch (FileNotFoundException fileNotFound)
            {
                Console.WriteLine($"Файл не найден: {fileNotFound.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
