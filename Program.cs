var parkingSystem = new ParkingSystem(1, 1, 1);

Console.WriteLine(parkingSystem.AddCar(1));
Console.WriteLine(parkingSystem.AddCar(2));
Console.WriteLine(parkingSystem.AddCar(3));
Console.WriteLine(parkingSystem.AddCar(1));

Console.ReadKey();
public class ParkingSystem
{
    public int SmallSlots { get; set; }
    public int MediumSlots { get; set; }
    public int BigSlots { get; set; }

    public ParkingSystem(int smallSlots, int mediumSlots, int bigSlots)
    {
        SmallSlots = smallSlots;
        MediumSlots = mediumSlots;
        BigSlots = bigSlots;
    }

    public bool AddCar(int carType)
    {
        if (carType == 1 && BigSlots > 0)
        {
            BigSlots--;
            return true;
        }
        if (carType == 2 && MediumSlots > 0)
        {
            MediumSlots--;
            return true;
        }
        if (carType == 3 && SmallSlots > 0)
        {
            SmallSlots--;
            return true;
        }
        return false;
    }


}

