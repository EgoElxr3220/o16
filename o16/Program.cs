using o16;
internal class Program
{
    private static void Main(string[] args)
    {
        Truck truck = new Truck();
        truck.StartEngine();
        truck.LoadCargo();

        Car car = new Car();
        car.StartEngine();
        car.PlayRadio();

        Motorcycle motorcycle = new Motorcycle();
        motorcycle.StartEngine();
        motorcycle.DoWheelie();
    }
}