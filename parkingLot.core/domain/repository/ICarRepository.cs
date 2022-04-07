using ParkingLots.domain.model;

namespace ParkingLots.domain.repository;

public interface ICarRepository
{
    public Car GetCar(long id);
    public Car AddCar(string mark);
}