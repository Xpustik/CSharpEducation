using System.Collections;

namespace Phonebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result;

            var abonents = PhoneBook.Instance;

            string commands = "Выберите действие: \n " +
                "1.Найти абонента \n " +
                "2.Добавить абонента \n " +
                "3.Удалить абонента \n " +
                "4.Посмотреть список \n " +
                "5.Выход \n";
            Console.WriteLine(commands);

            Console.WriteLine("Путь : " + new FileInfo(typeof(PhoneBook).Assembly.Location).DirectoryName);
            Console.WriteLine(Path.Combine(new FileInfo(typeof(PhoneBook).Assembly.Location).DirectoryName, "notebook.txt"));
           
            do 
            {               
                result = Console.ReadLine();

                switch (result) 
                {
                    case "1":
                        Console.WriteLine("Введите имя или номер абонента");
                        string value = Console.ReadLine();
                        if (value == null) value = " ";
                        abonents.FindAbonent(abonents.abonent, value);
                       // Console.WriteLine(result);
                        break;
                    case "2":
                        abonents.AddAbonent(abonents.abonent, Abonent.CreatAbonent());
                        //Console.WriteLine(result);
                        break;
                    case "3":
                        Console.WriteLine(result);
                        break;
                    case "4":
                        Abonent.PrintAbonent(abonents.abonent);
                        //Console.WriteLine(result);
                        break;
                    default: break;
                }
            } 
            while (result != "5");

            abonents.WriteFile(abonents.DeConvDataBase(abonents.abonent));
            
        }
        
    }
}
