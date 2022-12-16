public class salesman
{
    customer c;

    public salesman(customer c)
    {
        this.c = c;
    }

    public void buy(Car b)
    {
        Console.WriteLine("Here you go " + c.title);

        c.budget = c.budget - b.price;

        Console.WriteLine("Your new budget is");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(c.budget);

    }
    


}