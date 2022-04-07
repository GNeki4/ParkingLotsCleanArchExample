using ParkingLots.domain.model;
using ParkingLots.domain.repository;

namespace parkingLot.infrastructure.in_memory_database;

public class ParkingLotRepository : IParkingLotRepository
{
    private readonly Dictionary<long, ParkingLot> _parkingLots = new();
    private long _nextIndex = 1;

    public ParkingLot GetParkingLot(long id)
    {
        return _parkingLots[id];
    }

    public ParkingLot AddParkingLot(string place)
    {
        var parkingLot = new ParkingLot(_nextIndex, place);
        _parkingLots[_nextIndex] = parkingLot;
        _nextIndex++;
        return parkingLot;
    }
}