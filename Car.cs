class car
{
    int door;
    int wheels;
    int price;
    int speed;
    string model;

    List<string> carTypes = new List<string>();
    

    public car(int door, int wheels, int price, int speed, string model)
    {
        carTypes.Add("Tesla");
        carTypes.Add("Mecedes");
        carTypes.Add("BMW");
        carTypes.Add("Aygo");
        carTypes.Add("Citroën Cactus");


        switch (model)
        {
            case "1": //Tesla

                break;

            case "2": //Mecedes

                break;

            case "3": //BMW

                break;

            case "4": //Aygo

                break;

            case "5": //Citroën Cactus

                break;
        }

    }

}