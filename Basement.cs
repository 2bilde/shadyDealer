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
            Console.WriteLine("Welcome " + cus.title);
            Console.WriteLine("As you can see we have a lot in stock right now so what would you like? \nKeep in mind we dont have much time so you can only choose 1.");
            //makes list of drugs and prints them with numbers
            List<(string,int)> drugList = new List<(string,int)>(7) //limited to 7 (more ram efficient), string name and int price pr gram
            {
                ("Cocain",1), 
                ("Heroin",2), 
                ("Blue Crystal",3), 
                ("Weed",4), 
                ("2C-B",5), 
                ("Speed",6),
                ("Khat",7)
            };
            for (int i = 0; i < drugList.Count; i++){
                Console.WriteLine("[" + (i+1) + "] - " + drugList[i].Item1 + " - " + drugList[i].Item2 + "$ per gram");
            }
            int choice;
            while(!Int32.TryParse(Console.ReadLine(), out choice) || choice <= 0 || choice > drugList.Count); //infinite inputs untill they follow rules (potentially tell them to do it properly)

            Console.WriteLine("Ahh so you want some " + drugList[choice-1].Item1 + " that will be $" + drugList[choice-1].Item2 + " per gram");
            if (drugList[choice-1].Item2 * 100 < cus.budget){
                Console.WriteLine("So how many grams do you want?");
                int grams;
                while(!Int32.TryParse(Console.ReadLine(), out grams) || grams < 100)
                {
                Console.WriteLine("I'm sorry? i dont think i heard that right. This aint no small business buddy. we operating in MINIMUM 100grams. \nSo how much did you want again?");
                grams = Convert.ToInt32(Console.ReadLine());
                }

            
            }
            Console.WriteLine("I see you are low on money at the time. How about we go back upstairs...");
            
            
        }
        else {
            Console.WriteLine("i think you got the wrong idea bozo. Lets go back upstairs...");
        }
        
    }




}