using ParkingLots.domain.model;
using ParkingLots.domain.repository;

namespace parkingLot.infrastructure.in_memory_database;

public class CarRepository : ICarRepository
{
    private Dictionary<long, Car> _cars = new();
    private long _nextIndex = 1;
    
    public Car GetCar(long id)
    {
        return _cars[id];
    }

    public Car AddCar(string mark)
    {
        var car = new Car(_nextIndex, mark);
        _cars[_nextIndex] = car;
        _nextIndex++;
        return car;
    }
}