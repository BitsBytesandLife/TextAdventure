using System;

namespace TextAdventure
{
    
    class Program
    {
        private static taAppUI taUI;
        static void Main(string[] args)
        {
            Combat.LetsFight();

            //taUI = new taAppUI();
            //DisplayMenu();
            //RunMenuOptions();
            //Console.WriteLine("Hello World!");
        }



        public static void DisplayMenu()
        {

            Console.WriteLine("Text Adventure");
            Console.WriteLine("1  Create Player");
            Console.WriteLine("2  Start Playing");
            Console.WriteLine("3  Combat Test");
            Console.WriteLine("4  Exit");
        }


        public static void MenuHeader(string header)
        {
            Console.Clear();
            Console.WriteLine($"---- {header} ---");
        }

        public static void ContinueApp()
        {

            bool userResponse = taAppUI.GetUserConsent("Would you like to continue?");

            if (userResponse == true)
            {
                Console.Clear();
                DisplayMenu();
                RunMenuOptions();
            }
            else
                Console.WriteLine("Exit the application");
            return;
        }


        public static void RunMenuOptions()
        {
            string menuItem = taAppUI.ValidateChoices("Select a type in a number from 1 - 4 \n" +
                                                      "to choose your menu item", new string[] { "1", "2", "3", "4"});


            switch (menuItem)
            {
                case "1":
                    MenuHeader("Create a Palyer");
                    Console.WriteLine("Create a Player"); ;
                    ContinueApp();
                    break;
                case "2":
                    MenuHeader("Start a Game");
                    Console.WriteLine("Start a Game");
                    ContinueApp();
                    break;
                case "3":
                    MenuHeader("Combat Test");
                    Combat.LetsFight();
                    //ContinueApp();
                    break;
                case "4":
                    MenuHeader("Exit Application");
                    return;

            }

        }

    }



    
}
