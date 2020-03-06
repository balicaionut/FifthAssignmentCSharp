namespace FifthAssignmentCSharp.AnimalClasses
{
    class Cat : Animal
    {
        public double personalityScore { get; set; }

        public Cat():base()
        {
            personalityScore = 0.0;
        }

        public Cat(string type, string name, string breed, string color, int age, double pers) : base(type, name, breed, color, age)
        {
            this.personalityScore = pers;
        }

        //The following method demonstrates Overwriting
        //(VS was flaging this method and requested that I write the 'new' keyword)
        public string displayInfo()
        {
            return "Type of animal: " + typeAnimal + "\nName: " + name + "\nBreed: " + breed + "\nColor: " + color + "\nAge: " + age + "\nPersonality Score: " + personalityScore;
        }
    }
}
