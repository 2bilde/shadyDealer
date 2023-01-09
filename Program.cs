Console.ForegroundColor = ConsoleColor.White;
string intro = "DATE: 20TH OF APRIL";
Console.ForegroundColor = ConsoleColor.Gray;

foreach(char ch in intro){
    Console.Write(ch);
    Thread.Sleep(100);
}
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkGray;
Thread.Sleep(1000);
Console.WriteLine("*You walk into a car dealership and the dealer approaces you*\n");
Thread.Sleep(2500);
Console.ForegroundColor = ConsoleColor.Gray;

Console.WriteLine("Hello, what is your name?\n");

Customer c = new Customer();

Car car = new Car(c, 4);
Console.ReadLine();
