using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Xml.Linq;

namespace Phonebook
{
    public class PhoneBook
    {
        internal List<Abonent> abonent;

        private PhoneBook()
        {
            if (File.Exists(DataBase()))
                abonent = ConvDataBase(ReadFile());
            else
            { 
                Console.WriteLine("Base is empty");
                abonent = new List<Abonent>();
            }
        }

        private static readonly Lazy<PhoneBook> instans =
            new Lazy<PhoneBook>(() => new PhoneBook());

        public static PhoneBook Instance => instans.Value;


        private string DataBase()
        {
            string path2 = "notebook.txt";
            string fileDbName = Path.Combine(new FileInfo(typeof(PhoneBook).Assembly.Location).DirectoryName, path2);
            return fileDbName;
        }
        private string ReadFile()
        {
            string json = File.ReadAllText(DataBase());
            return json;
        }

        internal void WriteFile(string json)
        {
            if (File.Exists(DataBase()))
                File.WriteAllText(DataBase(), json);
            else
            {
                Console.WriteLine("File is exists");
                File.WriteAllText(DataBase(), json);
            }
            
        }
        private List<Abonent> ConvDataBase(string json)
        {
            List<Abonent> abonents = JsonConvert.DeserializeObject<List<Abonent>>(json);
            return abonents;
        }
        internal string DeConvDataBase(List<Abonent> abonents) 
        {
            string item = JsonConvert.SerializeObject(abonents);
            return item;
        }
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
        public void AddAbonent(List<Abonent> abonents, Abonent abonent)
        {
            if (abonents == null) abonents.Add(abonent);
            else if (abonents.Contains(abonent) == false) abonents.Add(abonent);
            else Console.WriteLine("Абонет уже есть в списке");
        }

        public void FindAbonent(List<Abonent> abonents, string name)
        {
            bool chek = true;
            foreach (var item in abonents)
            {
                if (item.Name == name)
                { 
                    Console.WriteLine(item.Name + " " + item.NumberPhone);
                    chek = false;
                    break;
                }
                else if (item.NumberPhone == name)
                { 
                    Console.WriteLine(item.Name + " " + item.NumberPhone); 
                    chek |= false;
                    break;
                }
                
            }
            if  (chek == true)
                Console.WriteLine("Абонетта нет в списке");

        }
    }
}
