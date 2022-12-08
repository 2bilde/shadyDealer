class Car
{
    int door = 0;
    int price = 0;
    int speed = 0;
    int model = 0;


    List<string> carTypes = new List<string>();


    public Car(int door, int wheels, int price, int speed, int model)
    {
        carTypes.Add("Tesla");
        carTypes.Add("Mecedes");
        carTypes.Add("BMW");
        carTypes.Add("Aygo");
        carTypes.Add("Citroën Cactus");

        while ()
        {

            Random rndModel = new Random();
            model = rndModel.Next(1, 5);

            price = rng.Next(budget / 2, (budget / 5) * 6);

            switch (model)
            {
                case 1: //Tesla
                    Console.WriteLine("\nAhh yes the " + carTypes[0] + " model. The one we have in store right now has the following");
                    Console.WriteLine(door);
                    Console.WriteLine(speed);

                    Console.WriteLine("\nThe cars price is $" + price);

                    if (price >= c.budget)
                        Console.WriteLine("You have enough money to buy the veichle");
                    Console.WriteLine("Would you like to buy it?");
                    basement.GetStringInput();

                    break;

                case 2: //Mecedes
                    Console.WriteLine("\nAhh yes the " + carTypes[1] + " model. The one we have in store right now has the following");
                    Console.WriteLine(door);
                    Console.WriteLine(speed);
                    break;

                case 3: //BMW
                    Console.WriteLine("\nAhh yes the " + carTypes[2] + " model. The one we have in store right now has the following");
                    Console.WriteLine(wheels);
                    Console.WriteLine(door);
                    Console.WriteLine(speed);
                    break;

                case 4: //Aygo
                    Console.WriteLine("\nAhh yes the " + carTypes[3] + " model. The one we have in store right now has the following");
                    Console.WriteLine(wheels);
                    Console.WriteLine(door);
                    Console.WriteLine(speed);
                    break;

                case 5: //Citroën Cactus
                    Console.WriteLine("\nAhh yes the " + carTypes[4] + " model. The one we have in store right now has the following");
                    Console.WriteLine(wheels);
                    Console.WriteLine(door);
                    Console.WriteLine(speed);
                    break;
            }

        }
    }
}