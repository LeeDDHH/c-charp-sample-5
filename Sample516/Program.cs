namespace Sample516
{
    class Program
    {
        static void DriveACar(IDrive car)
        {
            car.Drive();
            // car.Maintain();
        }
        static void MaintainACar(IMechanical car)
        {
            // car.Drive();
            car.Maintain();
        }

        static void Main(string[] args)
        {
            Car c = new Car();
            DriveACar((IDrive)c);
            MaintainACar((IMechanical)c);
        }
    }
}
