//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Phonebooks
{
    public class Abonent
    {
       /// <summary>
       /// Имя абонента
       /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Номер абонента
        /// </summary>
        public string NumberPhone {  get; set; }
        /// <summary>
        /// Создает объект класса с полями "Имя абонента" и "Номер абонента"
        /// </summary>
        /// <param name="name"> Имя абонента </param>
        /// <param name="numberPhone"> Номер абонента </param>
        public Abonent(string name, string numberPhone) 
        {
            this.Name = name;
            this.NumberPhone = numberPhone;
        }
               
        /// <summary>
        /// Создает новый объект класса Abonent и предлогает заполнить поля Name and NumberPhone
        /// </summary>
        /// <returns>Объект класса Abonent с поля Name and NumberPhone </returns>
        internal static Abonent CreatAbonent()
        {
            Console.WriteLine("Введите имя абонента");
            string? nameAbonent = Console.ReadLine();
           
            Console.WriteLine("Введите номер абонента");
            string? numberAbonent = Console.ReadLine();
            
            var item = new Abonent(nameAbonent, numberAbonent);

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
