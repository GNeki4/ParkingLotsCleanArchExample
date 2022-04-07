using ParkingLots.domain.model;
using ParkingLots.domain.repository;

namespace parkingLot.service;

public class ParkingLotsService
{
    private readonly ICarRepository _carRepo;
    private readonly IParkingLotRepository _parkingLotRepo;
    
    public ParkingLotsService(ICarRepository carRepo, IParkingLotRepository parkingLotRepo)
    {
        _carRepo = carRepo;
        _parkingLotRepo = parkingLotRepo;
    }

    public Car AddCar(string mark)
    {
        return _carRepo.AddCar(mark);
    }

    public Car GetCar(long carId)
    {
        return _carRepo.GetCar(carId);
    }

    public ParkingLot GetParkingLot(long parkingLotId)
    {
        return _parkingLotRepo.GetParkingLot(parkingLotId);
    }

    public ParkingLot AddParkingLot(string place)
    {
        return _parkingLotRepo.AddParkingLot(place);
    }

    public List<Booking> GetBookings(long carId)
    {
        return _carRepo.GetCar(carId).GetBookings();
    }

    public Booking AddBooking(long carId, long parkingLotId, string time)
    {
        var car = _carRepo.GetCar(carId);
        return car.AddBooking(parkingLotId, time);
    }
}