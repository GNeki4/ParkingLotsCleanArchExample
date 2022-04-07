using ParkingLots.domain.model;

namespace ParkingLots.domain.repository;

public interface IParkingLotRepository
{
    public ParkingLot GetParkingLot(long id);
    public ParkingLot AddParkingLot(string place);
}