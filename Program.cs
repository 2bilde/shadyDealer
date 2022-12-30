// ting der skal laves:
//  -   bedre/mere flydende historie
//  -   Buy Drugs method (inheritance from buy cars?)
//  -   Enter Basement story

Console.WriteLine("What is your full name?");

Customer c = new Customer();

Console.WriteLine(c.ToString());
Car car = new Car(c, 4);
Console.WriteLine(c.ToString());
Console.ReadLine();
