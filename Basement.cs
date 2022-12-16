class basement
{
    string buyD; //Buy Drugs
    string ExitB; //Exit Basement
    string EnterB; //Enter Basement
    private bool _isLocked = true;
    private int _password;
    customer player;


    public basement(int code, string EnterB, customer cus) //
    {
        _password = code;
        code = 1234;

        player = cus;
        Console.WriteLine("Ohh i see how it is. Well follow me " + cus.title);
        Thread.Sleep(1000);
        Console.WriteLine("Please enter the secret code");
    }

    public bool secretCode(int code)
    {

        if (_password == code)
        {
            _isLocked = false;
        }
        
        return _isLocked;

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

            else
            {
                return input;
            }
        }
    }
}