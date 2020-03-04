using System;
using FifthAssignmentCSharp.AnimalClasses;
using FifthAssignmentCSharp.HouseClasses;

namespace FifthAssignmentCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat();
            cat1.name = "Luna";
            cat1.breed = "Persian";
            cat1.color = "black";
            cat1.age = 3;
            cat1.personalityScore = 2.5;

            Console.WriteLine();
            Console.WriteLine(cat1.displayInfo());
            Console.WriteLine();
            Console.WriteLine(cat1.displayInfo(cat1.name));
            Console.WriteLine();
            Console.WriteLine(cat1.displayInfo(cat1.name, cat1.age));
            Console.WriteLine();

            Cat cat2 = new Cat("Flufy", "Turkish Angora", "white", 5, 3.5);

            Console.WriteLine();
            Console.WriteLine(cat2.displayInfo());
            Console.WriteLine();


            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();
        }
    }
}
