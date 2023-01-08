public class Util {
    public static string CheckIfNull(string input) //tjekker om brogeren rent faktisk har skrevet et input
    {
            input = input.Trim(); //trimmer inputtet så de ikke bare kan skrive " "
            while (input == null || input.Length == 0)
            {
                Console.WriteLine("please try again");
                input = GetStringInput();
            }
            return input;
    }
    public static string GetStringInput(Customer? c = null) //tjekker om inputtet er "iddqd"
    {
        while (true)
        {
            var input = Console.ReadLine();

            if (input == "iddqd" && c != null)
            {
                new basement(c);
                Console.WriteLine("so did you want to buy the car?");
            }
            else 
            {
                return input;
            }
        }
    }
}