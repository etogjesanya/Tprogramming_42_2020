using System;

namespace CourseApp
{
    public class Person
    {
        private string name;
        private int age;
        private string temperament;

        public Person()
        : this("Anonym")
        {
        }

        public Person(string name)
        : this(name, 1, "Not defined")
        {
        }

        public Person(string name, int age)
        : this(name, age, "Not defined")
        {
        }

        public Person(string name, string temperament)
        : this(name, 1, temperament)
        {
        }

        public Person(string name, int age, string temperament)
        {
            this.name = name;
            this.age = age;
            this.temperament = temperament;
        }

        public int Age
    {
        get
        {
            return age;
        }

        set
        {
            if (value < 1)
            {
            }
            else
            {
                age = value;
            }
        }
    }

     public string Temperament
        {
            get
            {
                return temperament;
            }

            set
            {
                string[] temperamentList = new string[] { "Sanguine", "Phlegmatic", "Choleric", "Melancholic", };
                foreach (string i in temperamentList)
                {
                    if (i == value)
                    {
                        temperament = value;
                        break;
                    }
                    else
                    {
                    }
                }
            }
        }

        public void DisplayAllInfo()
        {
            Console.WriteLine($"Name: {name}. Age: {age}. Temperament: {temperament}.");
        }

        public void DisplayNameAgeInfo()
        {
            Console.WriteLine($"Name: {name}.  Age: {age}.");
        }

        public void DisplayNameTemperamentInfo()
        {
            Console.WriteLine($"Name: {name}. Temperament: {temperament}.");
        }
    }
}