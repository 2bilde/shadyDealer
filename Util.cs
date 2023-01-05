public class Util {
    public static string CheckIfNull(string input)
    {
            input = input.Trim();
            while (input == null || input.Length == 0)
            {
                Console.WriteLine("please try again");
                input = GetStringInput();
            }
            return input;
    }
    public static string GetStringInput(Customer? c = null)
    {
        while (true)
        {
            var input = Console.ReadLine();

            if (input == "iddqd" && c != null)
            {
                new basement(c);
            }
            else 
            {
                return input;
            }
        }
    }
}