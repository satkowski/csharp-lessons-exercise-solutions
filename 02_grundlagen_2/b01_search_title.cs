using System;

namespace ExerciseSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] titles = { "Einführung in die Medieninformatik",
                                "Einführung in die Mathematik für Informatiker",
                                "Userinterface",
                                "Informations- und Kodierungstheorie",
                                "Entwurfsmuster von Kopf bis Fuß",
                                "Moderne Betriebssysteme",
                                "Logik und Logikprogrammierung",
                                "Künstliche Intelligenz" };

            // Read the search query from the console.
            Console.WriteLine("What is the search query:");
            string searchQuery = Console.ReadLine();

            // Only continue if the search querey has 3 or more characters.
            while(searchQuery.Length < 3)
            {
                Console.WriteLine("The search query was too short. Please enter a new one:");
                searchQuery = Console.ReadLine();
            }

            // Get a title and decide if a title was found or not.
            string outputTitle = SearchFirstTitle(titles, searchQuery);
            if(outputTitle.Length > 0)
                Console.WriteLine("The title found is: " + outputTitle + ".");
            else
                Console.WriteLine("No tile was found.");

            Console.ReadLine();
        }

        static string SearchFirstTitle(string[] titles, string searchQuery)
        {
            // Iterate through all avaible titles.
            for(int c = 0; c < titles.Length; c++)
            {
                // If the title contains the search query return the given title.
                if(titles[c].Contains(searchQuery))
                    return titles[c];
            }
            // If no title was found return the emtpy string.
            return "";
        }
    }
}
