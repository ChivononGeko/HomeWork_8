using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository rep = new Repository();
            Dictionary<List<int>, string> contact = new Dictionary<List<int>, string>();
            string number;
            #region Добавление номера   
            do
            {
                List<int> list = new List<int>();
                Console.WriteLine("Введите номер телефона без '8' и '+'(можно несколько)...");
                number = Console.ReadLine();
               
                do
                {
                    if (int.TryParse(number,out int result))
                    {
                        list.Add(result);
                    }
                    else
                    {
                        Console.WriteLine("Неверный формат, повторите еще раз...");
                    }
                  
                    Console.WriteLine("Для завершения ввода номеров введите пустую строку, либо введите еще номер...");
                   
                    number = Console.ReadLine();
                
                } while (number != "");
            #endregion
          
            #region Добавление ФИО и создание элемента словаря
                Console.WriteLine("Введите ФИО владельца номера(ов)...");
                string fio = Console.ReadLine();
            
                contact.Add(list, fio);

                Console.WriteLine("Для выхода нажмите Tab, для добавления еще записей нажмите любые остальные клавиши...");
           
            } while (Console.ReadKey().Key != ConsoleKey.Tab);
            #endregion
           
            #region Поиск ФИО по номеру
            do
            {
                Console.WriteLine("Для поиска ФИО по номеру телефона введите его..."); number = Console.ReadLine();
               
                if (int.TryParse(number, out int result))
                {
                    if (rep.Search(result, contact))
                    {
                        Console.WriteLine("Такого номера нет...");
                    }

                }
                else
                {
                    Console.WriteLine("Неверный формат, повторите еще раз...");
                }
                Console.WriteLine("Для выхода нажмите Tab, для продоллжения поиска нажмите любые остальные клавиши...");
          
            } while (Console.ReadKey().Key != ConsoleKey.Tab);
            #endregion
        }
    }
}
