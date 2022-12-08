class customer
{
    string sex;
    public int budget;
    string name;
    string surName;
    string title; //mr. ms. etc


    public customer(int budget, string jobs, string name)
    {
        //budget and gender is random
        Console.WriteLine("What is your full name?");
        name = basement.GetStringInput();
        while (name == null)
        {
            Console.WriteLine("please try again");
            name = basement.GetStringInput();
        }
        string[] splitted = name.Split(' ');
        surName = splitted[splitted.Length - 1];
        Console.WriteLine("what is your title (Mr., Ms., Mrs. etc");
        title = basement.GetStringInput();
        while (title == null)
        {
            Console.WriteLine("please try again");
            title = basement.GetStringInput();
        }

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
}