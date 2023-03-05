
namespace ConsoleApp2
{
    public class Car : AbstractVehicle
    {
        public int Id;

        public Car(int id)
        { 
            Id = id;
        }

        public override void Move()
        {
            Console.WriteLine($"я блять кибертачка {Id}");
        }

        public virtual void StartEngine()
        {
            Console.WriteLine("двигатель завелся");
        }
    }
}
