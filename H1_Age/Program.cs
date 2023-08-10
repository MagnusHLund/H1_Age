namespace H1_Age
{
    internal class Program
    {
        static void Main()
        {
            // Creates 2 DateTime variables, for the date of birth, as well as today
            DateTime born, today;

            // Assigns value of now to the "today" variable
            today = DateTime.Now;

            // Tells user what to write, as well as the format and does a readline, for user input.
            Console.WriteLine("Write when you were born, dd/mm/yyyy");
            string date = Console.ReadLine();

            // Checks if user input is valid, else the user has to try again
            while (!DateTime.TryParseExact(date, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out born))
            {
                Console.WriteLine("Invalid date, please retry");
                date = Console.ReadLine();
            }

            // Calculates the time difference between today and date of birth
            TimeSpan span = today - born;

            // Gets the total years of the span and puts it into the "years" variable
            int years = (int)Math.Floor(span.TotalDays / 365.2425f);

            // Adds the total of years, into the "born" variable and calculates the time span again, to calculate number of days since last birthday
            born = born.AddYears(years);
            span = today - born;

            // calculates the days and puts it into the newly created "days" variable
            int days = (int)Math.Floor(span.TotalDays);

            // Outputs the results into the console
            Console.WriteLine($"you are {years} years and {days} days old");
        }
    }
}