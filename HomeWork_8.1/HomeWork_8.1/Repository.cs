using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_8._1
{
    class Repository
    {
        /// <summary>
        /// Метод для заполнения 
        /// </summary>
        /// <param name="list">Список, куда сохраняются данные</param>
        /// <param name="count">Число элементов в списке</param>
        public void Placeholder(List<int>list,int count)
        {
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                list.Add(random.Next(0, 100));
            }
        }
        /// <summary>
        /// Метод печати данных в консоль
        /// </summary>
        /// <param name="list">Список, который нужно распечатать</param>
        public void Print(List<int> list)
        {
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
        }
        /// <summary>
        /// Метод удаления определенных данных
        /// </summary>
        /// <param name="list">Список</param>
        public void Delete(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > 25 && list[i] < 50)
                {
                    list.RemoveAt(i);
                }
            }
                       
        }
    }
}
