class customer
{
    string sex;
    public int budget;
    string name;
    string surName;
    public string title; //mr. ms. etc


    public customer(int budget, string name)
    {
        //budget and sex is random
        Console.WriteLine("What is your full name?");
        name = basement.GetStringInput();
        CheckIfNull(name);
        
        string[] splitted = name.Split(' ');
        surName = splitted[splitted.Length - 1];
        Console.WriteLine("what is your title (Mr., Ms., Mrs. etc");
        title = basement.GetStringInput();
        CheckIfNull(title);

        Random rng = new Random();
        int rngSex = rng.Next(1, 2);
        switch (rngSex)
        {
            case 1:
                sex = "male";
                break;
            case 2:
                sex = "female";
                break;
        }

        budget = rng.Next(100000, 200000);
        if (sex == "female")
        {
            budget = (budget / 4) * 3;
        }

        
    }
    public void CheckIfNull(string input)
        {
            while (input == null)
            {
                Console.WriteLine("please try again");
                input = basement.GetStringInput;
            }
        }
}