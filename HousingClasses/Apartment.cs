namespace FifthAssignmentCSharp.HousingClasses
{
    class Apartment : Housing
    {
        public int floor { get; set; }
        public int totalBuildingFloors { get; set; }
        public Apartment()
        {
            typeHousing = "";
            totalFloorArea = 0;
            price = 0.0;
            floor = 0;
            totalBuildingFloors = 0;
        }
        public Apartment(string type, int area, double price, int floor, int totalFloors)
        {
            this.typeHousing = type;
            this.totalFloorArea = area;
            this.price = price;
            this.floor = floor;
            this.totalBuildingFloors = totalFloors;
        }

        //The following method demonstrates Overwriting
        //(VS was flaging this method and requested that I write the 'new' keyword)
        public new string displayInfo()
        {
            return "Type of housing: " + typeHousing + "\nTotal floor area: " + totalFloorArea + " m2" + "\nFloor: " + floor + " out of " + totalBuildingFloors + "\nPrice: " + price + " euro";
        }
    }
}
