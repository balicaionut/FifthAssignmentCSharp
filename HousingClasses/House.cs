namespace FifthAssignmentCSharp.HousingClasses
{
    class House : Housing
    {
        public int noFloors { get; set; }
        public int totalYardArea { get; set; }
        public House() : base()
        {
            noFloors = 0;
            totalYardArea = 0;
        }
        public House(string type, int area, double price, int floors, int outArea) : base (type, area, price)
        {
            this.noFloors = floors;
            this.totalYardArea = outArea;
        }

        //The following method demonstrates Overwriting
        //(VS was flaging this method and requested that I write the 'new' keyword)
        public new string displayInfo()
        {
            return "Type of housing: " + typeHousing + "\nNumber of floors: " + noFloors +"\nTotal floor area: " + totalFloorArea + " m2" + "\nTotal yard area: " + totalYardArea + "\nPrice: " + price + " euro";
        }
    }
}
