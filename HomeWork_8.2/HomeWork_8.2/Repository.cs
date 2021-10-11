using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_8._2
{
    class Repository
    {
        /// <summary>
        /// Поиск имен по номеру телефона
        /// </summary>
        /// <param name="number">Номер телефона</param>
        /// <param name="contact">Словарь контактов</param>
        /// <returns></returns>
        public bool Search(int number, Dictionary<List<int>, string> contact)
        {
            bool flag = true;
                foreach (var list in contact.Keys)
                {
                    foreach (var vnum in list)
                    {
                       if (vnum == number)
                       {
                         contact.TryGetValue(list, out string value);
                         Console.WriteLine(value);
                         flag = false;
                       }
                    }
                }
            return flag;
        }
    }
}
