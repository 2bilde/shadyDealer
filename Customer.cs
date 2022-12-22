using static Util;
public class Customer
{
    string sex;
    public double budget;
    string name;
    string surName;
    public string title; //mr. ms. etc


    public Customer()
    {
        //budget and sex is random
        name = GetStringInput();
        name = CheckIfNull(name);
        
        string[] splitted = name.Split(' ');
        surName = splitted[splitted.Length - 1];

        Console.WriteLine("what is your title (Mr., Ms., Mrs., Etc.)");
        title = GetStringInput();
        title = CheckIfNull(title);

        Random rng = new Random();
        budget = rng.Next(100000, 200000);

        int rngSex = rng.Next(1, 2);
        switch (rngSex)
        {
            case 1:
                sex = "male";
                break;
            case 2:
                sex = "female";
                budget *= 3.0/4.0;
                break;
        }
        
    }
}