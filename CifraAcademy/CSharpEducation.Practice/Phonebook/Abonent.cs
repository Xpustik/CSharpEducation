using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    public class Abonent
    {
        private string name;
        private string numberPhone;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string NumberPhone
        {
            get
            {
                return numberPhone;
            }
            set 
            {
                numberPhone = value;
            }
        }
        /// <summary>
        /// Выводит в консоль объект из списка "abonents" при совпадении любого поля с "name"
        /// </summary>
        /// <param name="abonents"></param>
        /// <param name="name"></param>
        public static void FindAbonent(List<Abonent> abonents,string name)
        {
            foreach (var item in abonents)
            {
                if (item.Name == name)
                    Console.WriteLine(item.Name + " " +  item.NumberPhone);
                if (item.NumberPhone == name)
                    Console.WriteLine(item.Name + " " + item.NumberPhone);
                if ((item.Name != name) && (item.NumberPhone != name))
                    Console.WriteLine("Абонетта нет в списке");
            }
        }
        /// <summary>
        /// Удаляет объект из списка "abonents" при совподении любого поля с "name"
        /// </summary>
        /// <param name="abonents"></param>
        /// <param name="name"></param>
        public void DelAbonent(List<Abonent> abonents, string name) 
        {
            foreach (var item in abonents)
            {
                if (item.Name == name)
                    abonents.Remove(item);
                else if (item.NumberPhone == name) 
                    abonents.Remove(item);
            }
        }
        /// <summary>
        /// Добовляет объект класса "abonent" в  список "abonents" при условии что похожий объект отсутствует
        /// </summary>
        /// <param name="abonents"></param>
        /// <param name="abonent"></param>
        public static void AddAbonent(List<Abonent> abonents, Abonent abonent)
        {
            if (abonents == null) abonents.Add(abonent);
            else if (abonents.Contains(abonent) == false) abonents.Add(abonent);
            else Console.WriteLine("Абонет уже есть в списке");
        }
        /// <summary>
        /// Создает новый объект класса Abonent и предлогает заполнить поля Name and NumberPhone
        /// </summary>
        /// <returns>Объект класса Abonent с поля Name and NumberPhone </returns>
        internal static Abonent CreatAbonent()
        {
            var item = new Abonent();

            Console.WriteLine("Введите имя абонента");
            string? nameAbonent = Console.ReadLine();
            item.Name = nameAbonent;

            Console.WriteLine("Введите номер абонента");
            string? numberAbonent = Console.ReadLine();
            item.NumberPhone = numberAbonent;

            return item;

        }
        /// <summary>
        /// Выводит в консоль список
        /// </summary>
        /// <param name="abonents"></param>
        public static void PrintAbonent(List<Abonent> abonents)
        {
            if (abonents.Count == 0)
                Console.WriteLine("Cписок пуст");
            else
                Console.WriteLine(String.Join(Environment.NewLine, abonents));
        }
        public override string ToString()
        {
            return $"Name: {Name} \t Number Phone: {NumberPhone}";
        }
    }
}
