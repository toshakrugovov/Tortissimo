using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tortiki
{
    public class UUU
    {
        ConsoleKeyInfo key;
        DateTime now = DateTime.Now;
        string opisanie = " ";
        public int position = 3;
        public int symma = 0;

        public int Menu()
        {
            
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("***Кондитерская МПТшка, приветствует Вас!***");
            Console.WriteLine("======================================");
            Console.WriteLine("Давайте узнаем ваши предпочтения: ");
            Console.WriteLine("  1. Форма");
            Console.WriteLine("  2. Вес");
            Console.WriteLine("  3. Начинка");
            Console.WriteLine("  4. Количество");
            Console.WriteLine("  5. Глазурь");
            Console.WriteLine("  6. Сохранить заказ!");
            Console.WriteLine("Стоимость заказа: " + symma);
            Console.WriteLine("Текущее время: " + DateTime.Now);
            Console.WriteLine("Ваши предпочтения:\n" + opisanie);
            
            do { 

                Console.SetCursorPosition(0, position);
            Console.Write("=>");
            key = Console.ReadKey();
            
            
                if (key.Key == ConsoleKey.UpArrow && position >= 4)
                {
                    position--;
                    Console.Clear();
                    Menu();
                }
                if (key.Key == ConsoleKey.DownArrow && position <= 7)
                {
                    position++;
                    Console.Clear();
                    Menu();
                }
                if (key.Key == ConsoleKey.Enter && position == 8)
                {
                    Console.WriteLine("Ваш заказ отправлен в кондитерскую!!");
                    Console.WriteLine("Для создания нового заказа нажмите 2 раза на  Escape");

                    Soxr(symma, opisanie);

                }

                if (key.Key == ConsoleKey.Enter)
                {
                    return position;
                }
                
            }while (key.Key != ConsoleKey.Escape);

            symma = 0;
            opisanie = "";




            return 0;


        }
        private void Soxr(int symma, string opisanie)
        {
            if (!File.Exists("C:\\Users\\Home\\Desktop\\Тортики - C#\\Torti\\zakaz.txt"))
            {
                File.Create("C:\\Users\\Home\\Desktop\\Тортики - C#\\Torti\\zakaz.txt");
            }

            File.AppendAllText("C:\\Users\\Home\\Desktop\\Тортики - C#\\Torti\\zakaz.txt",
                "\nЗаказ сделан: " + DateTime.Now + "\nОписание заказа: \n" + opisanie + ""
                + "Cтоимость заказа: " + symma + "\n\t");

            ConsoleKeyInfo key;
            key = Console.ReadKey();
            Console.Clear();
            Menu();
            

        }
        public void Dop(List<Tort> list)
        {
            int position = 0;
            do
            {
                Console.Clear();
                
                foreach (Tort tort in list)
                {
                    Console.WriteLine("    " + tort.Nazvanie +  tort.Cost);
                    
                }

               
                Console.WriteLine("==================================================================");
                Console.WriteLine("Нажмите S для выбора и Escape для того, чтобы вернуться в Меню");
                Console.WriteLine("==================================================================");
                if (key.Key == ConsoleKey.S)
                {
                    Console.WriteLine("Выбор сохранён!!!");
                }
                Console.SetCursorPosition(0, position);
                Console.Write("=>");
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow && position >= 1)
                {
                    position--;
                }
                if (key.Key == ConsoleKey.DownArrow && position < list.Count - 1)
                {
                    position++;
                }
                if (key.Key == ConsoleKey.S)
                {
                    opisanie += list[position].Nazvanie + "  " + list[position].Cost + ";" + "\n";
                    symma += list[position].Cost;
                }
            } while (key.Key != ConsoleKey.Escape);
            Menu();
            




        }
    }
}
