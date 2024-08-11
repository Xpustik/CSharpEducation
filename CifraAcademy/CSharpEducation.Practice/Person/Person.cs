namespace Person
{
    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                //name = value;
                if (name != null)  
                    name = "Noname";
                else name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public static void PerInfo(Person person)
        {
            Console.WriteLine($"Name: {person.Name}  Age: {person.Age}");
        }
    }
}
