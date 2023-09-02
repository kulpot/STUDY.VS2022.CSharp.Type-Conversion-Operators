using System;

//ref link:https://www.youtube.com/watch?v=2rNFUhkPBz8&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=32
//

class Scooter 
{
    public int Mileage { get; set; }
    //public static implicit operator Car(Scooter scoot)
    public static explicit operator Car(Scooter scoot)
    {
        return new Car { Mileage = scoot.Mileage };
    }
}
class Car 
{
    public int Mileage { get; set; }

}

class MainClass
{
    static void Main()
    {
        Scooter meScooter = new Scooter();
        //Car meCar = meScooter;
        Car meCar = (Car)meScooter; // explicit operator -- data loss --
        object o = meScooter;       // reference convertion
    }
}