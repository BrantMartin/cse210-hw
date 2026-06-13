using System;

class Program
{
    static void Main(string[] args)
    {
        int option = 0;
        while (option != 4)
        {

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            option = Convert.ToInt32(Console.ReadLine());

            if (option == 1)
            {
                BreathingActivity breathAct = new BreathingActivity();
                breathAct.Run();
            }
            else if (option == 2)
            {
                ReflectingActivity reflAct = new ReflectingActivity();
                reflAct.Run();
            }
            else if (option == 3)
            {
                ListingActivity listAct = new ListingActivity();
                listAct.Run();
            }
            else if (option == 4)
            {
                break;
            }
            else
            {
                Console.WriteLine("Input a choice from the menu.");
            }
        }
    }
}