public class Salesman
{
    Customer c;
    Car car;

    public Salesman(Customer c, Car car)
    {
        this.c = c;
        this.car = car;
    }

    public void buyCar()
    {
        Console.WriteLine("Here you go " + c.title);

        c.budget -= car.price;

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("-" + car.price);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Your new budget is " + c.budget);
        Console.ForegroundColor = ConsoleColor.Gray;

    }
    


}