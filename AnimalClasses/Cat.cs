namespace FifthAssignmentCSharp.AnimalClasses
{
    class Cat : Animal
    {
        public double personalityScore { get; set; }

        public Cat()
        {
            name = "";
            breed = "";
            color = "";
            age = 0;
            personalityScore = 0.0;
        }

        public Cat(string name, string breed, string color, int age, double pers)
        {
            this.name = name;
            this.breed = breed;
            this.color = color;
            this.age = age;
            this.personalityScore = pers;
        }
        public string displayInfo()
        {
            return "Name: " + name + "\nBreed: " + breed + "\nColor: " + color + "\nAge: " + age + "\nPersonality Score: " + personalityScore;
        }
    }
}
