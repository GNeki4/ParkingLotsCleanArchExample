using parkingLot.infrastructure.in_memory_database;
using parkingLot.service;
using ParkingLotsCleanArchExample;

var carsRepository = new CarRepository();
var parkingLotRepository = new ParkingLotRepository();
var parkingLotService = new ParkingLotsService(carsRepository, parkingLotRepository);

var parkingLotCli = new ParkingLotsCli(parkingLotService);

while (true)
{
    var input = Console.In.ReadLine();
    
    if (input is "q")
        break;
    
    var result = parkingLotCli.RunCommand(input);
    Console.Out.WriteLine(result);
}