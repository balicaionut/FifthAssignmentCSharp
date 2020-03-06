namespace FifthAssignmentCSharp.HousingClasses
{
    class Housing
    {
        public string typeHousing { get; set; }
        public int totalFloorArea { get; set; }
        public double price { get; set; }
        public Housing()
        {
            typeHousing = "";
            totalFloorArea = 0;
            price = 0.0;
        }
        public Housing(string type)
        {
            this.typeHousing = type;
            totalFloorArea = 0;
            price = 0.0;
        }
        public Housing(string type, int area, double price)
        {
            this.typeHousing = type;
            this.totalFloorArea = area;
            this.price = price;
        }

        //Next methods demonstarate the Overloading
        public string displayInfo()
        {
            return "Type of housing: " + typeHousing + "\nTotal floor area: " + totalFloorArea + " m2" + "\nPrice: " + price + " euro";
        }

        public string displayInfo(string t, int a)
        {
            return "Type of housing: " + typeHousing + "\nTotal floor area: " + totalFloorArea + " m2";
        }

        public string displayInfo(string t)
        {
            return "Type of housing: " + typeHousing;
        }
    }
}