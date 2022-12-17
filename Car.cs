public class Car
{
    int door;
    public int price;
    int speed;
    int model;
    string answer;
    customer c = null;

    List<string> carTypes = new List<string>();


    public Car(int door, int wheels, int price, int speed, int model)
    {
        carTypes.Add("Tesla");
        carTypes.Add("Mecedes");
        carTypes.Add("BMW");
        carTypes.Add("Aygo");
        carTypes.Add("Citroën Cactus");

        while (carTypes.Count != 0)
        {

            Random rnd = new Random();
            model = rnd.Next(1, carTypes.Count);

            price = rnd.Next(c.budget / 3, (c.budget / 5) * 6);

            switch (model)
            {
                case 1: //Tesla
                    Console.WriteLine("\nAhh yes the " + carTypes[0] + " model. with " + door + "doors and a top speed of " + speed);

                    Console.WriteLine("\nThe cars price is $" + price);

                    if (price >= c.budget)
                        Console.WriteLine("You have enough money to buy the vehicle");
                    Console.WriteLine("Would you like to buy it?");
                    answer = basement.GetStringInput();
                    while (answer != "yes" || answer != "no")
                    {
                        Console.WriteLine("Im sorry i didnt understand that. Please answer \nyes \nno");
                        answer = basement.GetStringInput();
                    }
                    if (answer == "yes")
                    {
                        new salesman(c);
                    }
                    else
                    {
                        Console.WriteLine("Well here is another model");
                    }
                    carTypes.Remove(carTypes[0]);
                    break;

                case 2: //Mecedes
                    Console.WriteLine("\nAhh yes the " + carTypes[1] + " model. with " + door + "doors and a top speed of " + speed);
                    break;

                case 3: //BMW
                    Console.WriteLine("\nAhh yes the " + carTypes[2] + " model. with " + door + "doors and a top speed of " + speed);
                    break;

                case 4: //Aygo
                    Console.WriteLine("\nAhh yes the " + carTypes[3] + " model. with " + door + "doors and a top speed of " + speed);
                    break;

                case 5: //Citroën Cactus
                    Console.WriteLine("\nAhh yes the " + carTypes[4] + " model. with " + door + "doors and a top speed of " + speed);
                    break;
            }

        }
        Console.WriteLine("Get the fuck out of here");
        basement.GetStringInput();
    }
}