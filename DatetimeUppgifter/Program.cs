namespace DatetimeUppgifter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("DateTime & TimeSpan: Svar till uppgifter:");
            Console.WriteLine("Uppgift 1: " + Uppgift1());
            Console.WriteLine("Uppgift 2: " + Uppgift2());
            Console.WriteLine("Uppgift 3: " + Uppgift3());
            Console.WriteLine("Uppgift 4: " + Uppgift4());
            Console.WriteLine("Uppgift 5: " + Uppgift5());
            Console.WriteLine("Uppgift 6: " + Uppgift6());
            // TODO uppg 3, 4 osv.
        }

        public static string Uppgift1()
        {
            DateTime Blåfolket = new DateTime(2009, 12, 18);
            DateTime Blåfolket2 = new DateTime(2022, 12, 8);
            TimeSpan Blåfolketväntetid = Blåfolket2 - Blåfolket;
            int Blåfolketväntedagar = (int)Blåfolketväntetid.TotalDays;


            return Blåfolketväntedagar.ToString(); // TODO
        }

        public static string Uppgift2()
        {
            DateTime BD = new DateTime(2007, 05, 03);
            TimeSpan Age = DateTime.Now - BD;
            int totalminute = (int)Age.TotalMinutes;
            int totalHour = (int)Age.TotalHours;
            int totalSeconds = (int)Age.TotalSeconds;
            int totaldays = (int)Age.TotalDays;

            return totaldays.ToString() + " " + totalHour.ToString() + " " + totalminute.ToString() + " " + totalSeconds.ToString(); // TODO
        }

        public static string Uppgift3()
        {
            DateTime BD = new DateTime(2007, 05, 03);
            TimeSpan Age = DateTime.Now - BD;
            TimeSpan DoubleAge = Age + Age;


            return DoubleAge.ToString(); // TODO
        }
        public static string Uppgift4()
        {
            DateTime Dag1 = new DateTime(2022, 3, 26);
            DateTime Dag2 = new DateTime(2022, 3, 27);
            TimeSpan Hour = Dag2 - Dag1;
            int totalHour = (int)Hour.TotalHours;

            return totalHour.ToString();
        }
        public static string Uppgift5()
        {
            DateTime Year1 = new DateTime(2023, 1, 1);
            DateTime Year2 = new DateTime(2024, 1, 1);
            DateTime Year3 = new DateTime(2025, 1, 1);
            TimeSpan erm = Year2 - Year1;
            TimeSpan erm2 = Year3 - Year2;
            int totalDays = (int)erm.TotalDays;
            int Days = (int)erm2.TotalDays;
            return totalDays.ToString() + " " + Days.ToString();
        }
        public static string Uppgift6()
        {
            DateTime Tid1 = new DateTime(2015, 7, 1, 1, 59, 30);
            DateTime Tid2 = new DateTime(2015, 7, 1, 2, 0, 30);
            TimeSpan Tiden = Tid2 - Tid1;
            int totalSecond = (int)Tiden.TotalSeconds;
            return Tiden.ToString();

        }
    }
}
