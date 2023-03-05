using ConsoleApp2;

var car1 = new Car(1);
var bike1 = new Bike();
var car2 = new Car(2);

var j = new Jiga(3);

j.StartEngine();
j.Move();
j.Move1();

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

List<AbstractVehicle> Vehicle = new List<AbstractVehicle>
{
    car1,
    bike1,
    car2
};

foreach (AbstractVehicle vehicle in Vehicle)
{
    vehicle.Move();
    vehicle.Move1();

    if (vehicle is Car)
    {
        //downcast
        Car a = ((Car)vehicle);
        a.StartEngine();

        //upcast
        var b = ((AbstractVehicle)vehicle);
        b.Move();
    }

    Console.WriteLine();
}
