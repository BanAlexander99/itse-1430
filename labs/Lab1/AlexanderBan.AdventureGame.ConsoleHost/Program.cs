/*
 * ITSE 1430
 * Fall 2023
 * Alexander Ban
 * Lab One
 */
ReadIntroduction();

var quit = false;
string command;
int coord = 4;


do
{
    ReadRoom(coord);
    switch (GetAction())
    {
        case "N": coord = MovePlayer(coord, "N"); break;
        case "S": coord = MovePlayer(coord, "S"); break;
        case "E": coord = MovePlayer(coord, "E"); break;
        case "W": coord = MovePlayer(coord, "W"); break;
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

static void ReadIntroduction ()
{
    Console.WriteLine("Welcome to the ITSE 1430 Adventure Game, created by Alexander Ban! \nYou awaken at the center of a dark room, the air heavy with dust. \nThe room is quiet, and the only features you see are heavy oak doors adorning each wall.\n With no other option, you begin walking.");
    return;
}
static string GetAction ()
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
static bool ConfirmAction()
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
static int MovePlayer ( int coordinate, string direction)
{
    switch (coordinate)
    {
        case 1: 
        switch (direction)
        {
            case "N": PlayError();  return 1;
            case "S": return 4;
            case "E": return 2;
            case "W": PlayError(); return 1;
            default: return 0;
        };
        
        case 2: 
        switch (direction)
        {
            case "N": PlayError(); return 2;
            case "S": return 5;
            case "E": return 3;
            case "W": return 1;
            default: return 0;
        }; 
        case 3: 
        switch (direction)
        {
            case "N": PlayError(); return 3;
            case "S": return 6;
            case "E": PlayError(); return 3;
            case "W":  return 2;
            default: return 0;
        };
        case 4: 
        switch (direction)
        {
            case "N": return 1;
            case "S": return 7;
            case "E": return 5;
            case "W": PlayError(); return 4;
            default: return 0;
        }; 
        case 5: 
        switch (direction)
        {
            case "N": return 2;
            case "S": return 8;
            case "E": return 6;
            case "W": return 4;
            default: return 0;
        };
        case 6: 
        switch (direction)
        {
            case "N": return 3;
            case "S": return 9;
            case "E": PlayError(); return 6;
            case "W": return 5;
            default: return 0;
        };
        case 7:
        switch (direction)
        {
            case "N": return 4;
            case "S": PlayError();  return 7;
            case "E": return 8;
            case "W": PlayError(); return 7;
            default: return 0;
        };
        case 8:
        switch (direction)
        {
            case "N": return 5;
            case "S": PlayError();  return 8;
            case "E": return 9;
            case "W": return 7;
            default: return 0;
        }; 
        case 9:
        switch (direction)
        {
            case "N": return 6;
            case "S": PlayError(); return 9;
            case "E": PlayError(); return 9;
            case "W": return 8;
            default: return 0;
        }; 
        default: Console.WriteLine("Where am I?"); return 0;
    }
};
static void ReadRoom ( int coordinate)
{
    switch (coordinate)
    {
        case 1: Console.WriteLine("Room One");  break;
        case 2: Console.WriteLine("Room Two");  break; 
        case 3: Console.WriteLine("Room Three");  break;
        case 4: Console.WriteLine("Room Four");  break;
        case 5: Console.WriteLine("Room Five");  break;
        case 6: Console.WriteLine("Room Six");  break;
        case 7: Console.WriteLine("Room Seven");  break;
        case 8: Console.WriteLine("Room Eight");  break;
        case 9: Console.WriteLine("Room Nine");  break;
    }
}
static void PlayError ()
{
    Console.WriteLine("Cannot move in that direction");
}

///Room Design
///1 2 3
///4 5 6
///7 8 9
///1: Ballroom 0,2
///2: Kitchen 1,2
///3: Armory 2,2
///4: Foyer (Start Here) 0,1
///5: Dining Hall 1,1
///6: Courtyard 2,1
///7: Pool 0,0
///8: Guest Room 1,0
///9: Master Bedroom 2,0