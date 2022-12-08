class customer{
    int money;
    string job;
    string gender;
    string name;
    string surName;
    string title; //mr. ms. etc

    
    public customer(int money, string jobs, string gender, string name){
        //money, job, gender random
        Console.WriteLine("What is your full name?");
        name = Console.ReadLine();
        while (name == null){
            Console.WriteLine("please try again");
            name = Console.ReadLine();
        }
        string[] splitted = name.Split(' ');
        surName = splitted[splitted.Length-1];
        Console.WriteLine("what is your title (Mr., Ms., Mrs. etc");
        title = Console.ReadLine();
        while (title == null){
            Console.WriteLine("please try again");
            title = Console.ReadLine();
        }
        Console.WriteLine("Hello " + title + ' ' + surName + ". So nice to see you today. It is my understanding that your budget is $" + money);
    }
}