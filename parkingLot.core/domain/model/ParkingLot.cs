namespace ParkingLots.domain.model;

public class ParkingLot
{
    private long ParkingLotId { get; set; }

    private string Place { get; set; }
    
    private List<Booking> Bookings { get; set; }
    
    public ParkingLot(long parkingLotId, string place)
    {
        ParkingLotId = parkingLotId;
        Place = place;
        Bookings = new List<Booking>();
    }

    public override string ToString()
    {
        return "Id: " + ParkingLotId + ", place: " + Place;
    }
}