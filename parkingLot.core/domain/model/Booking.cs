namespace ParkingLots.domain.model;

public class Booking
{
    private long CarId { get; set; }
    private long ParkingLotId { get; set; }
    private string Time { get; set; }

    public Booking(long carId, long parkingLotId, string time)
    {
        CarId = carId;
        ParkingLotId = parkingLotId;
        Time = time;
    }

    public override string ToString()
    {
        return "Car id: " + CarId + ", parking lot id: " + ParkingLotId + ", booking time: " + Time;
    }
}