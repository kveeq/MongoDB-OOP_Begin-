using System;

namespace MongoDB_OOP_Begin_
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Sasha", 18, "Kazan");
            person.Add(person);
            var lst = Person.TakeList();
            foreach (var item in lst)
            {
                Console.WriteLine($"{item.Name} {item.Age} {item.Addres}");
            }
        }
    }
}
