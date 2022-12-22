class basement
{
    
    string secretCode = "420";
    Customer player;


    public basement(Customer cus) //
    {
        player = cus;
        Console.WriteLine("Ohh i see how it is. Well follow me " + cus.title);
        Thread.Sleep(1000);
        Console.WriteLine("Please enter the secret code");
        string attempt = Console.ReadLine();
        if (attempt == secretCode){
            //all basement story here
            Console.WriteLine("Welcome " + cus.title);
            Console.WriteLine("As you can see we have a lot in stock right now so what would you like?");
            Console.WriteLine("Cocain");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

        }
        else {
            Console.WriteLine("i think you got the wrong idea bozo. Lets go back upstairs...");
        }
        
    }




}