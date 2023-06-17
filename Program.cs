using System.Globalization;

namespace Out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dateString = "2023-06-17";
            string format = "yyyy-MM-dd";
            DateTime parsedDate;

            if (TryParseExact(dateString, format, out parsedDate))
            {
                Console.WriteLine("Parsed Date: " + parsedDate.ToString());
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        public static bool TryParseExact(string input, string format, out DateTime result)
        {
            return DateTime.TryParseExact(input, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out result);
        }

    }
}