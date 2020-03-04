using System;
using FifthAssignmentCSharp.AnimalClasses;
using FifthAssignmentCSharp.HouseClasses;

namespace FifthAssignmentCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat1 = new Cat();
            cat1.name = "Tomy";
            cat1.breed = "Persian";
            cat1.color = "black";
            cat1.age = 3;

            Console.WriteLine();

            Console.WriteLine(cat1.displayInfo());
            Console.WriteLine();
            Console.WriteLine(cat1.displayInfo(cat1.name));
            Console.WriteLine();
            Console.WriteLine(cat1.displayInfo(cat1.name, cat1.age));
            Console.WriteLine();

            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();


            /*
            Console.WriteLine();
            Console.WriteLine("--- Animal Objects Exercise -----------------------------------");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue!");
            Console.ReadKey();

            Animal animal1 = new Animal();
            animal1.typeAnimal = "dog";
            animal1.color = "brwn";
            animal1.age = 3;
            Console.WriteLine();
            Console.WriteLine("Type: " + animal1.typeAnimal + "\nColor: " + animal1.color + "\nAge: " + animal1.age);

            Animal animal2 = new Animal("cat");
            animal2.color = "white";
            animal2.age = 6;
            Console.WriteLine();
            Console.WriteLine("Type: " + animal2.typeAnimal + "\nColor: " + animal2.color + "\nAge: " + animal2.age);

            Animal animal3 = new Animal("hamster", "red", 1);
            Console.WriteLine();
            Console.WriteLine("Type: " + animal3.typeAnimal + "\nColor: " + animal3.color + "\nAge: " + animal3.age);

            Console.WriteLine();
            Console.WriteLine("Press any key to continue!");

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--- House Objects Exercise -----------------------------------");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue!");
            Console.ReadKey();

            House house1 = new House();
            house1.typeHouse = "duplex";
            house1.noFloors = 2;
            house1.price = 185000.00;
            Console.WriteLine();
            Console.WriteLine("Type: " + house1.typeHouse + "\nFloors: " + house1.noFloors + "\nPrice: " + house1.price);

            House house2 = new House("villa");
            house2.noFloors = 3;
            house2.price = 475000.00;
            Console.WriteLine();
            Console.WriteLine("Type: " + house2.typeHouse + "\nFloors: " + house2.noFloors + "\nPrice: " + house2.price);

            House house3 = new House("apartment", 1, 65500.00);
            Console.WriteLine();
            Console.WriteLine("Type: " + house3.typeHouse + "\nFloors: " + house3.noFloors + "\nPrice: " + house3.price);

            Console.WriteLine();
            Console.WriteLine("Press any key to continue!");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--- Bonus :) -----------------------------------");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue!");
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine($"The {animal1.color} {animal1.typeAnimal} is {animal1.age} year old");
            Console.WriteLine($"and it lives in the {house1.noFloors} floors {house1.typeHouse}.");
            Console.WriteLine();
            Console.WriteLine($"The {animal2.color} {animal2.typeAnimal} is {animal2.age} year old");
            Console.WriteLine($"and it lives in the {house2.noFloors} floors fancy {house2.typeHouse}.");
            Console.WriteLine();
            Console.WriteLine($"But the poor little {animal3.color} {animal3.typeAnimal}");
            Console.WriteLine($"lives in a humbel {house3.typeHouse}.");
            Console.WriteLine();

            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();
            */
        }
    }
}
