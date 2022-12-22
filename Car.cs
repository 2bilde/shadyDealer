using static Util;
public class Car
{
    
    public int price;
    int speed;
    int wheels;
    CarType model;
    string answer;
    Customer customer = null;
    Door door;
    Engine engine;

    public Car(Customer customer, int wheels)
    {
        this.customer = customer;
        this.wheels = wheels;
        
        Random rnd = new Random();

        
        List<CarType> allModels = CarTypeMethods.GetAllTypes().OrderBy(item => rnd.Next()).ToList();
        Console.WriteLine("Your budget is $" + customer.budget);
        Console.Write("\nAhh yes ");
        foreach (CarType carModel in allModels)
        {

            model = carModel;
            door = new Door();
            engine = new Engine(model);

            price = rnd.Next((int)(customer.budget / 3.0), (int)((customer.budget / 4.0) * 5.0));

            Console.WriteLine("The " + model.Name() + " model. with " + door.doorAmount + " doors and a top speed of " + engine.topSpeed + "km/t");

            Console.WriteLine("\nThe cars price is $" + price);

            if (price <= customer.budget)
                Console.WriteLine("You have enough money to buy the vehicle");
            else {
                Console.WriteLine("You don't have enough money to buy this car, so lets skip to the next one.");
                continue;
            }
            Console.WriteLine("Would you like to buy it?");
            answer = GetStringInput(customer).ToLower();
            while (answer != "yes" && answer != "no")
            {
                Console.WriteLine("Im sorry i didnt understand that. Please answer \nyes \nno");
                answer = GetStringInput(customer).ToLower();
            }
            if (answer == "yes")
            {
                var salesman = new Salesman(customer, this);
                salesman.buyCar();
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
        GetStringInput(customer);
    }
}