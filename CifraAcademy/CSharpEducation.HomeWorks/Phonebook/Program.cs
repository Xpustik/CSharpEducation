//using System.Collections;

namespace Phonebooks
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

            do 
            {               
                result = Console.ReadLine();

                switch (result) 
                {
                    case "1":
                        Console.WriteLine("Введите имя или номер абонента");
                        string value = Console.ReadLine();
                        abonents.FindAbonent(abonents.abonent, value);
                        break;
                    case "2":
                       abonents.AddAbonent(abonents.abonent, Abonent.CreatAbonent());
                        break;
                    case "3":
                        Console.WriteLine("Введите имя или номер абонента");
                        value = Console.ReadLine();
                        abonents.DelAbonent(abonents.abonent, value);
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
