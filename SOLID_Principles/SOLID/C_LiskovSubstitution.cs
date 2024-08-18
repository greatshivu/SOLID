namespace SOLID_Principles.SOLID
{
    //How child class behaves with its parent class,
    //Base class instance replaced or substituted by child instance
    public class C_LiskovSubstitution
    {
       static void Main(string[] args)
       {
            C_Car car = new C_Car(4, 6000);
            Console.WriteLine(car.GetWheelsPrice()); 
            C_Bike bike = new C_Bike(2, 2000);
            Console.WriteLine(bike.GetWheelsPrice());
            //...

            //With Liskov
            C_Vehicle c_veh = new C_Car(4, 6000);
            Console.WriteLine(c_veh.GetWheelsPrice());
            C_Vehicle c_bike = new C_Bike(2, 2000);
            Console.WriteLine(c_bike.GetWheelsPrice());
        }
    }

    public abstract class C_Vehicle
    {
        public int Wheels { get; set; }
        public double WheelPrice { get; set; }
        public C_Vehicle(int wheels, double wheelPrice) { Wheels = wheels; WheelPrice = wheelPrice; }
        public abstract double GetWheelsPrice();
    }
    public class C_Car : C_Vehicle
    {
        public double DrumPrice { get; set; }
        public C_Car(int wheels, double wheelPrice) : base(wheels, wheelPrice) {}
        public override double GetWheelsPrice () {  return (Wheels * WheelPrice) + DrumPrice; }
    }
    public class C_Bike : C_Vehicle
    {
        public double RimPrice { get; set; }
        public C_Bike(int wheels, double wheelPrice) : base(wheels, wheelPrice) { }
        public override double GetWheelsPrice() { return (Wheels * WheelPrice) + RimPrice; }
    }
    
}
