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
            cat1.typeAnimal = "cat";
            cat1.name = "Luna";
            cat1.breed = "Persian";
            cat1.color = "black";
            cat1.age = 3;
            cat1.personalityScore = 2.5;

            //Next 3 methods demonstarate the Overloading
            Console.WriteLine();
            Console.WriteLine(cat1.displayInfo());
            Console.WriteLine();
            Console.WriteLine(cat1.displayInfo(cat1.name));
            Console.WriteLine();
            Console.WriteLine(cat1.displayInfo(cat1.name, cat1.age));
            Console.WriteLine();

            Cat cat2 = new Cat("cat", "Flufy", "Turkish Angora", "white", 5, 3.5);

            Console.WriteLine();
            Console.WriteLine(cat2.displayInfo());
            Console.WriteLine();

            Dog dog1 = new Dog();
            dog1.typeAnimal = "dog";
            dog1.name = "Spark";
            dog1.breed = "German Shepard";
            dog1.color = "brouwn";
            dog1.age = 2;
            dog1.trained = true;

            //Next 3 methods demonstarate the Overloading
            Console.WriteLine();
            Console.WriteLine(dog1.displayInfo());
            Console.WriteLine();
            Console.WriteLine(dog1.displayInfo(dog1.name));
            Console.WriteLine();
            Console.WriteLine(dog1.displayInfo(dog1.name, dog1.age));
            Console.WriteLine();

            Dog dog2 = new Dog("dog", "Lucy", "mixed breed", "black with white", 5, false);

            Console.WriteLine();
            Console.WriteLine(dog2.displayInfo());
            Console.WriteLine();



            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();
        }
    }
}
