using System;
using FifthAssignmentCSharp.AnimalClasses;
using FifthAssignmentCSharp.HousingClasses;

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

            Apartment ap1 = new Apartment();
            ap1.typeHousing = "Apartment";
            ap1.totalFloorArea = 78;
            ap1.price = 89000.00;
            ap1.floor = 2;
            ap1.totalBuildingFloors = 6;

            Console.WriteLine();
            Console.WriteLine(ap1.displayInfo());
            Console.WriteLine();

            Apartment ap2 = new Apartment("Apartment", 85, 95000.00, 1, 5);

            Console.WriteLine();
            Console.WriteLine(ap2.displayInfo());
            Console.WriteLine();

            House house1 = new House();
            house1.typeHousing = "House";
            house1.totalFloorArea = 180;
            house1.price = 219000.00;
            house1.noFloors = 2;
            house1.totalYardArea = 250;

            Console.WriteLine();
            Console.WriteLine(house1.displayInfo());
            Console.WriteLine();

            House house2 = new House("House", 150, 195000.00, 1, 150);

            Console.WriteLine();
            Console.WriteLine(house2.displayInfo());
            Console.WriteLine();

            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();
        }
    }
}
