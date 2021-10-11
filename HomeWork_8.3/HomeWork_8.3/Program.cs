using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            HashSet<int> set = new HashSet<int>();
            Console.WriteLine("Введите целое число...");
          
            do
            {
               string number = Console.ReadLine();         
            
                //Проверка на число
                if (int.TryParse(number, out int result))
                {
                    //Проверка наличия числа в коллекции
                    if (set.Contains(result))
                    {
                        Console.WriteLine("Такое число уже есть...");
                    }
                    else
                    {
                        set.Add(result);
                    }
                }
                else
                {
                    Console.WriteLine("Это не целое число...");
                }
            
                Console.WriteLine("Для выхода намите Tab, для продолжения любу. другую клавишу");
            
            } while (Console.ReadKey().Key != ConsoleKey.Tab);
            
            //Вывод в консоль
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
