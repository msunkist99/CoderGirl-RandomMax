using System;

namespace RandomMax
{
    public static class Program
    {
        public static void Main()
        {
            // TODO: Generate a list of 100 random integers between 0 and 1000 and ouput the maximum value.
            Random random = new Random();
            int largestRandomNumber = 0;

            for (int i = 0; i < 100; i++)
            {
                int randomNumber = random.Next(0, 1000);
                if (randomNumber > largestRandomNumber)
                {
                    largestRandomNumber = randomNumber;
                }
            }

            Console.WriteLine("Largest random number - " + largestRandomNumber);

            Console.ReadLine();
        }
    }
}
