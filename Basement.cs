class basement
{
    
    string secretCode = "42069";
    customer player;


    public basement(customer cus) //
    {
        player = cus;
        Console.WriteLine("Ohh i see how it is. Well follow me " + cus.title);
        Thread.Sleep(1000);
        Console.WriteLine("Please enter the secret code");
        string attempt = Console.ReadLine();
        if (attempt == secretCode){
            //all basement story here
            Console.WriteLine("Welcome " + player.title);
        }
        else {
            Console.WriteLine("i think you got the wrong idea bozo. Lets go back upstairs...");
        }
        
    }




}