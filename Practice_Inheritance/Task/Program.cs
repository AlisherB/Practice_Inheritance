using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task
{
    class Program
    {
        /*
        Цель: произвести расчет необходимого количества внешних носителей информации 
        при переносе за один раз важной информации (565 Гб, файлы по 780 Мб) с рабочего компьютера 
        на домашний компьютер и затрачиваемое на данный процесс время.  
        */
        static void Main(string[] args)
        {
            Calculation calc;
            int countFiles = 0;
            File[] files = new File[0];
            Storage[] storage;
            
            for (;;)
            {
                WriteLine("1 - Добавить файл");
                WriteLine("2 - Расчет времени");
                WriteLine("3 - Количество носителей");
                WriteLine("4 - Скопировать");
                WriteLine("Введите команду: ");
                int menu = Convert.ToInt32(ReadLine());
                switch (menu)
                {
                    case 0:
                        Array.Resize(ref files, files.Length + 1);
                        Console.WriteLine("Введите размер файла: ");
                        int size = Int32.Parse(Console.ReadLine());
                        files[countFiles] = new File(size);
                        if (files[countFiles].FileSize > 0)
                        {
                            Console.WriteLine("Файл успешно добавлен!");
                        }
                        else
                        {
                            Console.WriteLine("Неправильно введен размер!");
                        }
                        countFiles++;
                        Console.WriteLine("Нажмите чтобы вернуться назад!");
                        Console.ReadLine();
                        Console.Clear();

                        break;
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
            }
    }
}
