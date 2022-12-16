class basement
{
    string buyD; //Buy Drugs
    string ExitB; //Exit Basement
    string EnterB; //Enter Basement
    customer player;


    public basement(customer cus) //
    {
        player = cus;
        Console.WriteLine("Ohh i see how it is. Well follow me " + cus.title);
        Thread.Sleep(1000);
        Console.WriteLine("Please enter the secret code");
    }



    public static string GetStringInput(customer c = null)
    {
        while (true)
        {
            var input = Console.ReadLine();

            if (input == "iddqd" && c != null)
            {
                new basement(c);
            }
            else 
            {
                return input;
            }
        }
    }
}