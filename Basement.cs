class basement
{
    string buyD; //Buy Drugs
    string ExitB; //Exit Basement
    string EnterB; //Enter Basement
    private bool _isLocked = true;
    private int _password;
    customer player;



    public basement(string buyD, string ExitB, string EnterB, customer cus)
    {

        player = cus;
        Console.WriteLine("Ohh i see how it is. Well follow me " + cus.title);

    }



    public static string GetStringInput()
    {
        while (true)
        {
            var input = Console.ReadLine();

            if (input == "iddqd")
            {
                return "DrugStore";
            }

            else if (input != CheckIfNull)
            {
                return input;
            }
        }
    }
}