namespace SOLID_Principles.SOLID
{
    public class B_OpenClose
    {
        static void Main(string[] args)
        {
            B_WheelsService b_WheelsService = new B_WheelsService();
            //without open close principle
            Console.WriteLine(b_WheelsService.GetWheelsPrice(new B_Car()));
            Console.WriteLine(b_WheelsService.GetWheelsPrice(new B_Bike()));
            Console.WriteLine(b_WheelsService.GetWheelsPrice(new B_Bus())); //This method will throw exception

            //With open Close principle
            Console.WriteLine(b_WheelsService.GetWheelsPriceWithOpenClose(new B_Car()));
            Console.WriteLine(b_WheelsService.GetWheelsPriceWithOpenClose(new B_Bike()));
            Console.WriteLine(b_WheelsService.GetWheelsPriceWithOpenClose(new B_Bus()));
            Console.WriteLine(b_WheelsService.GetWheelsPriceWithOpenClose(new B_Truck()));
            Console.WriteLine(b_WheelsService.GetWheelsPriceWithOpenClose(new B_Auto()));
        }
    }
    
    public class B_Vehicle
    {
        public int Wheels { set; get; }
        public double Price { get; set; }
    }
    public class B_Car : B_Vehicle { }
    public class B_Bike : B_Vehicle { }
    public class B_Bus : B_Vehicle { }
    public class B_Truck : B_Vehicle { }
    public class B_Auto : B_Vehicle { }
    public class B_WheelsService
    {
        public double GetWheelsPrice(object vehicle) {
            if (vehicle is B_Car) { return ((B_Car)vehicle).Wheels * ((B_Car)vehicle).Price; }
            else if (vehicle is B_Bike) { return ((B_Bike)vehicle).Wheels * ((B_Bike)vehicle).Price; }
            //If Auto/Truck/Bus then we need to modify this class and method
            else { throw new Exception("we do not have instace of this"); }
        }
        //This works for car/bike/Auto/Truck/Bus any class
        public double GetWheelsPriceWithOpenClose(B_Vehicle vehicle) { return vehicle.Wheels * vehicle.Price; }
    }
}
