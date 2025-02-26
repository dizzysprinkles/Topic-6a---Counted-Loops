namespace Topic_6a___Counted_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 99; i >= 55; i--) //i++ is the same as i = i + 1 and i += 1
            {
                Console.Write(i + ", ");
            }

            int evenSum = 0;
            int oddSum = 0;
            Console.WriteLine("Question 4");
            Console.WriteLine("");
            for (int i = 20; i <= 40; i++)
            {
                if (i % 2 == 0) //If i is divisible by 2 it is even
                {
                    evenSum += i;
                }
                else  //If i is not divisible by 2 it is odd
                {
                    oddSum += i;
                }
            }
            Console.WriteLine($"Sum of odd numbers: {oddSum}");
            Console.WriteLine($"Sum of even numbers: {evenSum}");
        }
    }
}
