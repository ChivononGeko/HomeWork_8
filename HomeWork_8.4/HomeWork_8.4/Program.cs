using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWork_8._4
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Введите ФИО..."); string name = Console.ReadLine();
                Console.WriteLine("Введите улицу..."); string street = Console.ReadLine();
                Console.WriteLine("Введите номер дома..."); int housenumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Введиту номер квартиры..."); int flatnumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите номер мобильного..."); long mobilephone = long.Parse(Console.ReadLine());
                Console.WriteLine("Введите номер домашнего...."); int flatphone = int.Parse(Console.ReadLine());

                XElement Person = new XElement("Person");

                XElement Address = new XElement("Address");
                XElement Street = new XElement("Street");
                XElement HouseNumber = new XElement("HouseNumber");
                XElement FlatNumber = new XElement("FlatNumber");
             
                XElement Phones = new XElement("Phones");
                XElement MobilePhone = new XElement("MobilePhone");
                XElement FlatPhone = new XElement("FlatPhone");

                XAttribute attribute = new XAttribute("name", name);
                Person.Add(attribute);
            
                Street.Add(street);
                HouseNumber.Add(housenumber);
                FlatNumber.Add(flatnumber);
                MobilePhone.Add(mobilephone);
                FlatPhone.Add(flatphone);

                Person.Add(Address, Phones);
                Address.Add(Street, HouseNumber, FlatNumber);
                Phones.Add(MobilePhone, FlatPhone);

                Person.Save("person.xml");
        }
    }
}
