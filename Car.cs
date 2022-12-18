using static Util;
public class Car
{
    int door;
    public int price;
    int speed;
    int wheels;
    CarType model;
    string answer;
    customer c = null;

    public Car(customer c, int door, int wheels, int speed)
    {
        this.c = c;
        this.door = door;
        this.wheels = wheels;
        this.speed = speed;
        Random rnd = new Random();

        List<CarType> allModels = CarTypeMethods.GetAllTypes().OrderBy(item => rnd.Next()).ToList();

        foreach (CarType carModel in allModels)
        {

            model = carModel;

            price = rnd.Next((int)(c.budget / 3.0), (int)((c.budget / 5.0) * 6.0));

            Console.WriteLine("\nAhh yes the " + model.Name() + " model. with " + door + "doors and a top speed of " + speed);

            Console.WriteLine("\nThe cars price is $" + price);

            if (price <= c.budget)
                Console.WriteLine("You have enough money to buy the vehicle");
            else {
                Console.WriteLine("You don't have enough money to buy this car, so lets skip to the next one.");
                continue;
            }
            Console.WriteLine("Would you like to buy it?");
            answer = GetStringInput(c).ToLower();
            while (answer != "yes" && answer != "no")
            {
                Console.WriteLine("Im sorry i didnt understand that. Please answer \nyes \nno");
                answer = GetStringInput(c).ToLower();
            }
            if (answer == "yes")
            {
                var s = new salesman(c, this);
                s.buy();
                return;
            }
            else
            {
                Console.WriteLine("Well here is another model");
            }
            /*switch (model)
            {
                case CarType.Tesla: 
                    Console.WriteLine("\nAhh yes the " + model.Name() + " model. with " + door + "doors and a top speed of " + speed);

                    Console.WriteLine("\nThe cars price is $" + price);

                    if (price >= c.budget)
                        Console.WriteLine("You have enough money to buy the vehicle");
                    Console.WriteLine("Would you like to buy it?");
                    answer = GetStringInput(c);
                    while (answer != "yes" || answer != "no")
                    {
                        Console.WriteLine("Im sorry i didnt understand that. Please answer \nyes \nno");
                        answer = GetStringInput(c);
                    }
                    if (answer == "yes")
                    {
                        new salesman(c);
                    }
                    else
                    {
                        Console.WriteLine("Well here is another model");
                    }
                    break;

                case CarType.Mercedes: 
                    Console.WriteLine("\nAhh yes the " + model.Name() + " model. with " + door + "doors and a top speed of " + speed);
                    break;

                case CarType.BMW:
                    Console.WriteLine("\nAhh yes the " + model.Name() + " model. with " + door + "doors and a top speed of " + speed);
                    break;

                case CarType.Toyota:
                    Console.WriteLine("\nAhh yes the " + model.Name() + " model. with " + door + "doors and a top speed of " + speed);
                    break;

                case CarType.Citröen:
                    Console.WriteLine("\nAhh yes the " + model.Name() + " model. with " + door + "doors and a top speed of " + speed);
                    break;

                case CarType.Aston_Martin:
                    Console.WriteLine("\nAhh yes the " + model.Name() + " model. with " + door + "doors and a top speed of " + speed);
                    break;
            }*/

        }
        Console.WriteLine("Unfortunetly we don't have any more cars. So get the fuck out of here!");
        GetStringInput(c);
    }
}