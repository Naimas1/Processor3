using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processor3
{
    internal class ParentApp
    {
        void Main(string[] args)
        {
            // Путь к исполняемому файлу дочернего процесса
            string childProcessPath = "ChildApp.exe";

            // Аргументы командной строки для дочернего процесса
            string[] childArgs = { "6", "4", "+" };

            // Создание нового процесса для запуска дочернего приложения
            Process childProcess = new Process();
            childProcess.StartInfo.FileName = childProcessPath;
            childProcess.StartInfo.Arguments = string.Join(" ", childArgs);

            try
            {
                // Запуск дочернего процесса
                childProcess.Start();

                // Ожидание завершения дочернего процесса
                childProcess.WaitForExit();

                // Вывод кода завершения дочернего процесса
                Console.WriteLine("Дочерний процесс завершился с кодом: " + childProcess.ExitCode);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при запуске дочернего процесса: " + ex.Message);
            }
        }
    }
}
