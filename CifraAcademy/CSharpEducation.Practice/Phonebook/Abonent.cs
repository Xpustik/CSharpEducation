using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebooks
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
