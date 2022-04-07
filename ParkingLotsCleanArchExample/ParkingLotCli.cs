using System.Text;
using parkingLot.service;

namespace ParkingLotsCleanArchExample;

public class ParkingLotsCli
{
    private readonly ParkingLotsService _parkingLotsService;
    
    public ParkingLotsCli(ParkingLotsService parkingLotsService)
    {
        _parkingLotsService = parkingLotsService;
    }
    
    public string? RunCommand(string? command)
    {
        var parts = command!.Split(" ");
        object result;
    
        if (parts.Length > 1)
            switch (parts[0])
            {
                case "add_car":
                    result = _parkingLotsService.AddCar(parts[1]);
                    return "Car added: " + result;
                    
                case "get_car":
                    result = _parkingLotsService.GetCar(long.Parse(parts[1]));
                    return result.ToString();
                    
                case "add_parking":
                    result = _parkingLotsService.AddParkingLot(parts[1]);
                    return "Parking lot added: " + result;
                    
                case "get_parking":
                    result = _parkingLotsService.GetParkingLot(long.Parse(parts[1]));
                    return result.ToString();
                    
                case "book":
                    if (parts.Length < 4)
                        return "Аргументы введены неверно.";
                    else
                    {
                        result = _parkingLotsService.AddBooking(long.Parse(parts[1]), long.Parse(parts[2]), parts[3]);
                        return result.ToString();
                    }
                    
                case "get_car_bookings":
                    var bookings = _parkingLotsService.GetBookings(long.Parse(parts[1]));
                    var builder = new StringBuilder("Все брони машины: " + "\n");
                    foreach (var booking in bookings)
                        builder.Append(booking + "\n");
        
                    return builder.ToString();
            }

        return "Неверная команда, попробуйте снова.";
    }
}