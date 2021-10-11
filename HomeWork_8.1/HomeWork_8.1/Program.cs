using System;
using System.Collections.Generic;

namespace HomeWork_8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 100;
            
            List<int> list = new List<int>();
            
            Repository rep = new Repository();
           
            rep.Placeholder(list, count); //Заполнение
            rep.Print(list);              //Печать
            
            Console.ReadKey();            
            Console.WriteLine();          
            
            rep.Delete(list);             //Удаление
            rep.Print(list);              //Печать
        }
    }
}
