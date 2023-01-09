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
        surName = splitted[splitted.Length - 1]; //splitter "name" ved mellemrum og får den sidste del som efternavn

        Console.WriteLine("what is your title (Mr., Ms., Mrs., Etc.)");
        title = Console.ReadLine();
        title = CheckIfNull(title);

        Random rng = new Random(); //budget mellem 100k og 200k
        budget = rng.Next(100000, 200000);

        int rngSex = rng.Next(1, 2); //hvis du er kvinde er dit budget 3/4 af hvad det startede med
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