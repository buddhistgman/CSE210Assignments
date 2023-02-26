using System;

class Program {
    static void Main()
    {
        ShowMenu();
        
        
    }
    
    
    public static void ShowMenu()
    {
        string input = "";
        //Time time;
        BreatheActivity breathing;
        ListingActivity listing;
        ReflectingActivity reflecting;
        
        while (input != "4")
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");

            Console.WriteLine("Select a choice from the menu: ");
            input = Console.ReadLine();

            if (input == "1")
            {
                Console.Clear();
                breathing = new BreatheActivity();
                breathing.showActivityIntro();
                breathing.setActivityTime();
                Console.Clear();
                breathing.runBreathing();
                Console.Clear();
                breathing.showActivityEndMessage();
                Console.Clear();
            }
            else if (input == "2")
            {
                Console.Clear();
                reflecting = new ReflectingActivity();
                reflecting.showActivityIntro();
                reflecting.setActivityTime();
                Console.Clear();
                reflecting.runReflecting();
                Console.Clear();
                reflecting.showActivityEndMessage();
                Console.Clear();
            }
            else if (input == "3")
            {
                Console.Clear();
                listing = new ListingActivity();
                listing.showActivityIntro();
                listing.setActivityTime();
                Console.Clear();
                listing.runListing();
                Console.Clear();
                listing.showActivityEndMessage();
                Console.Clear();
            }
            else if (input == "4")
            {
                Console.Clear();
                Console.WriteLine("Goodbye.");
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }
}