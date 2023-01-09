class basement
{

    string secretCode = "420";
    Customer player;


    public basement(Customer cus) //
    {
        player = cus; //det her virker ligegyldigt? bare erstat "cus" med "player" tror jeg
        Console.WriteLine("Ohh i see how it is. Well follow me " + cus.title);
        Thread.Sleep(1000);
        Console.WriteLine("Please enter the secret code");
        string attempt = Console.ReadLine();

        if (attempt != secretCode)
        { //hvis de skrievr den forkerte kode

            Console.WriteLine("You dont seem to know the code... get out of here and ask Jesper Madsen");
            //Jesper du ved det godt

        }
        else
        { //hvis de skriver den rigtige kode
            Console.WriteLine("Welcome " + cus.title);
            Console.WriteLine("As you can see we have a lot in stock right now so what would you like? \nKeep in mind we dont have much time so you can only choose 1.");
            //makes list of drugs and prints them with numbers (placeholders for price)
            List<(string, int)> drugList = new List<(string, int)>(7) //limited to 7 (more ram efficient), string name and int price pr gram
            {
                ("Cocain",50),
                ("Heroin",30),
                ("Blue Crystal",40),
                ("Weed",35),
                ("2C-B",20),
                ("Speed",15),
                ("Khat",5)
            };
            for (int i = 0; i < drugList.Count; i++)
            { //skriver stofferne som en liste i prigrammet med tallene 1-7 til at vælge
                Console.WriteLine("[" + (i + 1) + "] - " + drugList[i].Item1 + " - " + drugList[i].Item2 + "$ per gram");
            }
            int choice;
            while (!Int32.TryParse(Console.ReadLine(), out choice) || choice <= 0 || choice > drugList.Count) ; //infinite inputs untill they follow rules

            Console.WriteLine("Ahh so you want some " + drugList[choice - 1].Item1 + " that will be $" + drugList[choice - 1].Item2 + " per gram");
            if (drugList[choice - 1].Item2 * 100 < cus.budget)
            { //hvis de har råd
                Console.WriteLine("So how many grams do you want?");
                int grams;
                while (!Int32.TryParse(Console.ReadLine(), out grams) || grams < 100) //hvis de vil have under 100g
                {
                    Console.WriteLine("I'm sorry? I dont think i heard that right. This aint no small business buddy. We are operating in MINIMUM 100 grams. \nSo how much did you want again?");
                    grams = Convert.ToInt32(Console.ReadLine());
                    while(cus.budget < (drugList[choice - 1].Item2*grams)){
                    Console.WriteLine("You dont have the fudns for that amount. Try a smaller amount...");
                    Int32.TryParse(Console.ReadLine(), out grams); //grams = Convert.ToInt32(Console.Readline()) er et alternativ
                    continue;
                    }
                }
                
                
                Console.WriteLine("Here you go " + cus.title);
                cus.budget -= (drugList[choice - 1].Item2 * grams);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" - " + (drugList[choice - 1].Item2 * grams));
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Your new budget is " + cus.budget);
                Console.ForegroundColor = ConsoleColor.Gray;

                Thread.Sleep(2000);
                Console.WriteLine("Thank you for doing business, now get out before the feds show up");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("So you come down here without enough money? Are you with the feds? GET OUT!"); //de har ikke råd
            }
            Console.ReadLine();
            Environment.Exit(1);
            
        }

    }




}