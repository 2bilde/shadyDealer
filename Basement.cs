class basement
{
    string buyD; //Buy Drugs
    string ExitB; //Exit Basement
    public basement(int buyD, int ExitB)
    {      
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