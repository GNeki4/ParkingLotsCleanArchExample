namespace ParkingLots.domain.model;

public class Car
{
    private long CarId { get; set; }
    
    private string Mark { get; set; }
    
    private List<Booking> Bookings { get; set; }
    
    public Car(long carId, string mark)
    {
        CarId = carId;
        Mark = mark;
        Bookings = new List<Booking>();
    }

    public Booking AddBooking(long parkingLotId, string time)
    {
        var booking = new Booking(CarId, parkingLotId, time);
        Bookings.Add(booking);
        return booking;
    }

    public List<Booking> GetBookings()
    {
        return Bookings;
    }

    public override string ToString()
    {
        return "Id: " + CarId + ", mark: " + Mark;
    }
}