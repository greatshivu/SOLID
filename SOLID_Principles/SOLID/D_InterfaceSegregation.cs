namespace SOLID_Principles.SOLID
{
    public class D_InterfaceSegregation
    {
    }

    #region Without Segregation
    public interface IVehicle
    {
        public int Wheels { get; set; }
        public double Price { get; set; }
        public string? BatteryType { get; set; }
        public string? FuelType { get; set; }
        public string? FuelTankCapacity { get; set; }
        public string? BatteryCapacity { get; set; }
        public int NumberOfThermalManagementSystem { get; set; }
        public int VehicleControlUnits { get; set; }
    }
    public class NormalCar : IVehicle
    {
        public int Wheels { set; get; }
        public double Price { set; get; }
        public string? BatteryType { set; get; }
        public string? FuelType { set; get; }
        public string? FuelTankCapacity { set; get; }
        public string? BatteryCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int NumberOfThermalManagementSystem { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int VehicleControlUnits { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
    #endregion

    #region With Segregation
    public interface D_IVehicle
    {
        public int Wheels { get; set; }
        public double Price { get; set; }
        public string? BatteryType { get; set; }
    }

    public interface D_IConventionalVehicle
    {
        public string? FuelType { get; set; }
        public string? FuelTankCapacity { get; set; }
    }
    public interface D_IElectricVehicle
    {
        public string? BatteryCapacity { get; set; }
        public int NumberOfThermalManagementSystem { get; set; }
        public int VehicleControlUnits { get; set; }
    }

    public class D_NormalCar : D_IVehicle, D_IConventionalVehicle
    {
        public int Wheels { set; get; }
        public double Price { set; get; }
        public string? BatteryType { set; get; }
        public string? FuelType { set; get; }
        public string? FuelTankCapacity { set; get; }
    }

    public class D_ElectricCar : D_IVehicle, D_IElectricVehicle
    {
        public int Wheels { set; get; }
        public double Price { set; get; }
        public string? BatteryType { set; get; }
        public string? BatteryCapacity { set; get; }
        public int NumberOfThermalManagementSystem { set; get; }
        public int VehicleControlUnits { set; get; }
    }

    public class D_ElectricBike : D_IVehicle, D_IElectricVehicle
    {
        public int Wheels { set; get; }
        public double Price { set; get; }
        public string? BatteryType { set; get; }
        public string? BatteryCapacity { set; get; }
        public int NumberOfThermalManagementSystem { set; get; }
        public int VehicleControlUnits { set; get; }
    }
    #endregion
}
