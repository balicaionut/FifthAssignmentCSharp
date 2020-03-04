namespace FifthAssignmentCSharp.HouseClasses
{
    class House
    {
        public string typeHouse { get; set; }
        public int noFloors { get; set; }
        public double price { get; set; }
        public House()
        {
            typeHouse = "";
            noFloors = 0;
            price = 0.0;
        }
        public House(string type)
        {
            this.typeHouse = type;
            noFloors = 0;
            price = 0.0;
        }
        public House(string type, int floors, double price)
        {
            this.typeHouse = type;
            this.noFloors = floors;
            this.price = price;
        }
    }
}