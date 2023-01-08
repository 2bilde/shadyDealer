using static Util;
public class Car
{
    
    public int price;
    bool gotCar = false;
    int wheels;
    CarType model;
    string answer;
    Customer customer = null;
    Door door;
    Engine engine;

    public Car(Customer customer, int wheels)
    {
        this.customer = customer;
        this.wheels = wheels;
        
        Random rnd = new Random();

        
        List<CarType> allModels = CarTypeMethods.GetAllTypes().OrderBy(item => rnd.Next()).ToList(); //får alle biler fra bil listen og laver dem til en tilfældig liste
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Your budget is $" + customer.budget);
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write("\nAhh yes ");
        
            foreach (CarType carModel in allModels) //går gennem alle biler en af gangen
            {
                while (gotCar == false){

                model = carModel;
                door = new Door();
                engine = new Engine(model);

                price = rnd.Next((int)(customer.budget / 3.0), (int)((customer.budget / 10.0) * 11.0));
                price = (int)((double)price*((double)engine.topSpeed/1000.0 + 1.0)); //sætter prisen baseret på topfart. hvis topfart er 200 er det pris * 1,200

                Console.WriteLine("The " + model.Name() + " model. with " + door.doorAmount + " doors and a top speed of " + engine.topSpeed + "km/t");

                Console.WriteLine("\nThe cars price is $" + price);

                if (price <= customer.budget) //tjekker om man har råd
                    Console.WriteLine("You have enough money to buy the vehicle");
                else {
                    Console.WriteLine("You don't have enough money to buy this car, so lets skip to the next one. \n");
                    Thread.Sleep(2500);
                    continue; //hvis man ikke har råd går den videre til næste bil
                }
                Console.WriteLine("Would you like to buy it?");
                answer = GetStringInput(customer).ToLower();
                while (answer != "yes" && answer != "no")
                {
                    Console.WriteLine("Im sorry i didnt understand that. Please answer \nyes \nno");
                    answer = GetStringInput(customer).ToLower(); //de skal svare ja eller nej"
                }
                if (answer == "yes")
                {
                    var salesman = new Salesman(customer, this);
                    salesman.buyCar();
                    Console.WriteLine("pleasure doing business."); //skriver IDDQD med store bogstaver så man har en chance for at gætte
                    Console.WriteLine("I think you shoulD be going now. unless you woulD like to play this again and Quiz me on more cars? Do what youd like. \nmaybe youll get a different experience");
                    gotCar = true;
                    continue;
                }
                else
                {
                    Console.WriteLine("Well here is another model \n");
                    continue;
                }
            }
        }
        if(gotCar == false){
            Console.WriteLine("Unfortunetly we don't have any more cars. So get the fuck out of here!"); //idk, slutning hvis de siger nej til det hele
        GetStringInput(customer);
        }
        else {
            Thread.Sleep(5000);
            Console.WriteLine("Well you got your car so get going already");
        }
        
    }
}