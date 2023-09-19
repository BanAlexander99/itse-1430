/*
 * ITSE 1430
 * Fall 2023
 * Alexander Ban
 * Lab One
 */
ReadIntroduction();

var quit = false;
string command;

do
{
    switch (GetAction())
    {
        case "N": command = "N"; break;
        case "S": command = "S"; break;
        case "E": command = "E"; break;
        case "W": command = "W"; break;
        case "Q":
        {
            if (ConfirmAction())
                quit = true; break;
        };
        //{
        //    quit = true;
        //    break;
        //};
        

    };
} while (!quit);

//Functions

void ReadIntroduction ()
{
    Console.WriteLine("Welcome to the ITSE 1430 Adventure Game, created by Alexander Ban! \nYou awaken at the center of a dark room, the air heavy with dust. \nThe room is quiet, and the only features you see are heavy oak doors adorning each wall.\n With no other option, you begin walking.");
    return;
}
string GetAction ()
{
    Console.WriteLine("----------");
    Console.WriteLine("N) Move North");
    Console.WriteLine("S) Move South");
    Console.WriteLine("E) Move East");
    Console.WriteLine("W) Move West");
    Console.WriteLine("Q) Quit Game");

    do
    {
        switch(Console.ReadKey(true).Key)
        {
            case ConsoleKey.N: return "N";
            case ConsoleKey.S: return "S";
            case ConsoleKey.E: return "E";
            case ConsoleKey.W: return "W";
            case ConsoleKey.Q: return "Q";
            default: Console.WriteLine("Command not recognized. Please try again."); break;
        };
    } while (true);
}
bool ConfirmAction()
{
    Console.WriteLine ("Are you sure? Y/N");
    while (true)
    {
        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.Y: return true;

            case ConsoleKey.N: return false;

            default: Console.WriteLine("Please enter Y/N"); break;
        };
    };

}

