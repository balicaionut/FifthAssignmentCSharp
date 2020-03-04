namespace FifthAssignmentCSharp.AnimalClasses
{
    class Animal
    {
        public string name { get; set; }
        public string breed { get; set; }
        public string color { get; set; }
        public int age { get; set; }
        public Animal()
        {
            name = "";
            breed = "";
            color = "";
            age = 0;
        }
        public Animal(string name, string breed, string color, int age)
        {
            this.name = name;
            this.breed = breed;
            this.color = color;
            this.age = age;
        }
        
        //Next methods demonstarate the Overloading
        public string displayInfo()
        {
            return "Name: " + name + "\nBreed: " + breed + "\nColor: " + color + "\nAge: " + age;
        }

        public string displayInfo(string t, int a)
        {
            return "Name: " + name + "\nAge: " + age;
        }

        public string displayInfo(string type)
        {
            return "Name: " + name;
        }
    }
}