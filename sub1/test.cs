using System;

class Program
{

    static void Main(string[] args)
    {
        string age = null;
        string name = "";

        do
        {
            Console.Write("please enter your name : ");
            name = Console.ReadLine();
            Console.Clear();
        } while (name == "") ;
        do
        {
            Console.Write("please enter your age : ");
            age = Console.ReadLine();
            Console.Clear();
            if (int.TryParse(age, out int ret) == false || ret < 0)
            {
                Console.WriteLine("Please enter a valid number");
                age = null;
            }
        } while (age == null) ;
        Console.WriteLine("Name : " + name);
        Console.WriteLine("Age : " + age);
    }
}