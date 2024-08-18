namespace SOLID_Principles.SOLID
{
    //One should depend upon abstraction not on concretion
    // => details should depend on abstraction and abstraction should not depend on details
    // => Adapter Design pattern implementats DIP
    public class E_DependencyInversionPrinciple
    {
    }

    #region Without DIP
    public class CarRepository
    {
        public void Save(A_Car vehicle) { }
    }
    public class BikeRepository
    {
        public void Save(A_Bike vehicle) { }
    }

    public class CarService
    {
        private readonly CarRepository _carRepository;
        public CarService()
        {
            _carRepository = new CarRepository();
        }
        public void Save(A_Car vehicle) { _carRepository.Save(vehicle); }
    }
    public class BikeService
    {
        private readonly BikeRepository _bikeRepository;
        public BikeService()
        {
            _bikeRepository = new BikeRepository();
        }
        public void Save(A_Bike vehicle) { _bikeRepository.Save(vehicle); }
    }
    #endregion

    //With DIP
    #region With DIP
    public interface IVehicleRepository { void Save(D_IVehicle vehicle); }
    public class VehicleRepositry : IVehicleRepository { public void Save(D_IVehicle vehicle) { } }
    public class E_CarService
    {
        private readonly IVehicleRepository _vehicleRepository;
        public E_CarService(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }
        public void Save(D_ElectricBike vehicle) { _vehicleRepository.Save(vehicle); }
    }
    public class E_BikeService
    {
        private readonly IVehicleRepository _vehicleRepository;
        public E_BikeService(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }
        public void Save(D_ElectricBike vehicle) { _vehicleRepository.Save(vehicle); }
    } 
    #endregion
}
