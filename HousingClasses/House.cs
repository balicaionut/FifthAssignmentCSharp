namespace FifthAssignmentCSharp.HousingClasses
{
    class House : Housing
    {
        public int noFloors { get; set; }
        public int totalYardArea { get; set; }
        public House()
        {
            typeHousing = "";
            totalFloorArea = 0;
            price = 0.0;
            noFloors = 0;
            totalYardArea = 0;
        }
        public House(string type, int inArea, double price, int floors, int outArea)
        {
            this.typeHousing = type;
            this.totalFloorArea = inArea;
            this.price = price;
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
