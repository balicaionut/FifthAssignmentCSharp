namespace FifthAssignmentCSharp.AnimalClasses
{
    class Dog : Animal
    {
        public bool trained { get; set; }

        public Dog()
        {
            typeAnimal = "";
            name = "";
            breed = "";
            color = "";
            age = 0;
            trained = false;
        }

        public Dog(string type, string name, string breed, string color, int age, bool trained)
        {
            this.typeAnimal = type;
            this.name = name;
            this.breed = breed;
            this.color = color;
            this.age = age;
            this.trained = trained;
        }

        //The following method demonstrates Overwriting
        //(VS was flaging this method and requested that I write the 'new' keyword)
        public new string displayInfo()
        {
            return "Type of animal: " + typeAnimal + "\nName: " + name + "\nBreed: " + breed + "\nColor: " + color + "\nAge: " + age + "\nTrained: " + trained;
        }
    }
}