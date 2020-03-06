namespace FifthAssignmentCSharp.AnimalClasses
{
    class Animal
    {
        public string typeAnimal { get; set; }
        public string name { get; set; }
        public string breed { get; set; }
        public string color { get; set; }
        public int age { get; set; }
        public Animal()
        {
            typeAnimal = "";
            name = "";
            breed = "";
            color = "";
            age = 0;
        }
        public Animal(string type, string name, string breed, string color, int age)
        {
            this.typeAnimal = type;
            this.name = name;
            this.breed = breed;
            this.color = color;
            this.age = age;
        }
        
        //Next methods demonstarate the Overloading
        public string displayInfo()
        {
            return "Type of animal: " + typeAnimal + "\nName: " + name + "\nBreed: " + breed + "\nColor: " + color + "\nAge: " + age;
        }

        public string displayInfo(string t, int a)
        {
            return "Type of animal: " + typeAnimal + "\nName: " + name + "\nAge: " + age;
        }

        public string displayInfo(string t)
        {
            return "Name: " + name;
        }
    }
}