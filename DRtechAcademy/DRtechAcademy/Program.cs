using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy \nStudent Daily Report");
            Console.ReadLine();

            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string yourCurrentCourse = Console.ReadLine();
            Console.WriteLine("What page number?");
            int yourCurrentPage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer true or false.");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string yourExperience = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string yourFeedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            // creating new variable to convert
            string hoursStudied = Console.ReadLine();
            int yourHoursStudied = Convert.ToInt32(hoursStudied);

            Console.WriteLine("Thank you for your answers. \nAn Instructor will respond to this shortly. Have a great day!” This is the end of the program.");
            Console.ReadLine();

    }
    
}
