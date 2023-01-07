// ting der skal laves:
//  -   bedre/mere flydende historie evt
//  -   Buy Drugs method
//  -   basement story efter køb af stoffer
//  -   historie efter en bil er købt
//  -   fix tiden efter man ikke har råd


Console.WriteLine("What is your full name?");

Customer c = new Customer();

Console.WriteLine(c.ToString()); //testede om classes var pointers, kan slettes
Car car = new Car(c, 4);
Console.WriteLine(c.ToString());
Console.ReadLine();
