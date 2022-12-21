public class salesman
{
    customer c;
    Car car;

    public salesman(customer c, Car car)
    {
        this.c = c;
        this.car = car;
    }

    public void buyCar()
    {
        Console.WriteLine("Here you go " + c.title);

        c.budget = c.budget - car.price;

        Console.WriteLine("Your new budget is");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("-" + car.price);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Your new budget is " + c.budget);
        Console.ForegroundColor = ConsoleColor.Gray;

    }
    


}