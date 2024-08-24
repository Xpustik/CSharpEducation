//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Text.Json;
//using System.ComponentModel;
using Newtonsoft.Json;
//using System.Xml.Linq;

namespace Phonebooks
{
    public class PhoneBook
    {
        /// <summary>
        /// Список объектов класса Abonent
        /// </summary>
        internal List<Abonent> abonent;
                
        #region Методы

        /// <summary>
        /// Ищет директорию где находится класс PhoneBook и создает путь к файлу "notebook.txt"
        /// </summary>
        /// <returns> Полный путь к файлу "notebook.txt" директории класса PhoneBook </returns>
        private string DataBase()
        {
            string path1 = "notebook.txt";
            string fileDbName = Path.Combine(new FileInfo(typeof(PhoneBook).Assembly.Location).DirectoryName, path1);
            return fileDbName;
        }
        /// <summary>
        /// Считывает текст из файла "notebook.txt"
        /// </summary>
        /// <returns> Весь текст из файла в виде строки</returns>
        private string ReadFile()
        {
            string json = File.ReadAllText(this.DataBase());
            return json;
        }
        /// <summary>
        /// Перезаписывает текст в файле "notebook.txt" в директории класса Abonent,
        /// если файла нет выводит в консоль сообщение "File is exists" и создает "notebook.txt" в директории класса Abonent
        /// для записи текста 
        /// </summary>
        /// <param name="json">Текст записываемый в файл "notebook.txt"</param>
        internal void WriteFile(string json)
        {
            if (File.Exists(this.DataBase()))
                File.WriteAllText(this.DataBase(), json);
            else
            {
                Console.WriteLine("File is exists");
                File.WriteAllText(this.DataBase(), json);
            }
        }
        /// <summary>
        /// Преобразует текст в формате json в список класса Abonent
        /// </summary>
        /// <param name="json"> текст в формате json</param>
        /// <returns> Список объектов класса Abonent</returns>
        private List<Abonent> ConvDataBase(string json)
        {
            List<Abonent> abonents = JsonConvert.DeserializeObject<List<Abonent>>(json);
            return abonents;
        }
        /// <summary>
        /// Преобразует список объектов класса Abonent в текс в формате json
        /// </summary>
        /// <param name="abonents">Список объектов класса Abonent</param>
        /// <returns>текс в формате json</returns>
        internal string DeConvDataBase(List<Abonent> abonents)
        {
            string item = JsonConvert.SerializeObject(abonents);
            return item;
        }
        /// <summary>
        /// Ищет объект по заданному значению поля и при совпадении любого поля объекта 
        /// удаляет найденный объект из списка класса Abonent 
        /// </summary>
        /// <param name="abonents"> список объектов класса Abonent</param>
        /// <param name="name">Значение поля объекта</param>
        internal void DelAbonent(List<Abonent> abonents, string name)
        {
            bool check = true;

            foreach (var item in abonents)
            {
                if (item.Name == name)
                {
                    abonents.Remove(item);
                    Console.WriteLine("Удален по имени");
                    check = false;
                    break;
                }
                else if (item.NumberPhone == name)
                {
                    abonents.Remove(item);
                    Console.WriteLine("Удален по номеру");
                    check = false;
                    break;
                }
            }
            if (check)
            {
                Console.WriteLine("Абонетта нет в списке");
            }
        }

         /// <summary>
            /// Проверяет наличие "abonent" в списке, при его отсутствии добавляет в список "abonents",
            /// при его наличии выводит сообщение "Абонет уже есть в списке"
            /// </summary>
            /// <param name="abonents">Список объектов класса Abonent в который нужно добавить объект </param>
            /// <param name="abonent"> объект класса который нужно добавить</param>
        internal void AddAbonent(List<Abonent> abonents, Abonent abonent)
        {
            if (abonents == null) abonents.Add(abonent);
            else if (abonents.Contains(abonent) == false) abonents.Add(abonent);
            else Console.WriteLine("Абонет уже есть в списке");
        }

        /// <summary>
        /// Находит объект класса из списка по значению поля и выводит значени полей объекта в консоль,
        /// если объекта нет выводит сообщение "Абонетта нет в списке"
        /// </summary>
        /// <param name="abonents">Список объектов класса Abonent в котором ищет объект</param>
        /// <param name="name">Значение поля по которому ищется объект</param>
        internal void FindAbonent(List<Abonent> abonents, string name)
        {
            bool check = true;
            foreach (var item in abonents)
            {
                if (item.Name == name)
                {
                    Console.WriteLine($"Name: {item.Name} \t Number Phone: {item.NumberPhone}");
                    check = false;
                    break;
                }
                else if (item.NumberPhone == name)
                {
                    Console.WriteLine($"Name: {item.Name} \t Number Phone: {item.NumberPhone}");
                    check |= false;
                    break;
                }

            }
            if (check == true)
                Console.WriteLine("Абонетта нет в списке");

        }

        #endregion

        #region Ленивая реализация паттерна Singleton

        /// <summary>
        /// Конструктор. При создании объекта класса PhoneBook проверяет наличие файла "notebook.txt",
        /// при положительном резельтате читает данные из файла "notebook.txt" и 
        /// записывает список объектов класса Abonent в поле abonent. Если файл отсутствует 
        /// выводит сообщение "Base is empty" и создает пустой список объектов класса Abonent
        /// </summary>
        private PhoneBook()
        {
            if (File.Exists(this.DataBase()))
                this.abonent = ConvDataBase(this.ReadFile());
            else
            {
                Console.WriteLine("Base is empty");
                this.abonent = new List<Abonent>();
            }
        }
        /// <summary>
        /// Вызывает конструктор класса PhoneBook только при первой инициализации
        /// </summary>
        private static readonly Lazy<PhoneBook> instans =
            new Lazy<PhoneBook>(() => new PhoneBook());
        /// <summary>
        /// Свойство. Вызывает процедуру создания единственного объекта класса PhoneBook.
        /// Ленивая инициализация паттерна Singleton
        /// </summary>
        public static PhoneBook Instance => instans.Value;
        #endregion
    }
}
