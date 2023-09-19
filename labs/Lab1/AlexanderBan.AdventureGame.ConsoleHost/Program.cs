/*
 * ITSE 1430
 * Fall 2023
 * Alexander Ban
 * Lab One
 */
ReadIntroduction();

var quit = false;
//string command;
int coord = 4;


do
{
    ShowMap(coord);
    ReadRoom(coord);
    if (GeneratePercentage() <=5)
        SeeShadows();
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
        case 1: Console.WriteLine("You feel an air of delight as you gaze at the bright ballroom before you. \nThe atmosphere is such that you can almost feel the mirth of past parties held in this grand arena.\n There are doors on the southern and eastern walls");  break;
        case 2: Console.WriteLine("The stale smell of bread fills your lungs as you step into this quiet kitchen.\n Rats scurry around you, grabbing what morsels of food are left.\nThere are doors to the west, south, and east.");  break; 
        case 3: Console.WriteLine("Rows of rusted swords and spears line the walls of this abandoned armory.\n The sight of so many tools of war fills you with a sense of dread, which you quickly shake off.\n There are exits on the west and south walls.");  break;
        case 4: Console.WriteLine("What was once a grand entrance way is now littered with cobwebs and dust.\n Two suits of armor flank the eastern door, forever guarding this abandoned portal.\nOther than the eastern door, you can travel north and south from here.");  break;
        case 5: Console.WriteLine("This room is dominated by two long dining tables, lined with luxurious satin tablecloths.\n You feel your empty stomach grumble as you imagine the feasts once held here.\n There is an exit in every direction.");  break;
        case 6: Console.WriteLine("At last you can see open air once you enter this courtyard.\nA couple of lone trees are all that grow in this now abandoned garden.\nYou can exit through the north, south, or west.");  break;
        case 7: Console.WriteLine("Not watching your step, you almost fall headfirst into the empty hole that once was a swimming pool. The silence in this room is almost deafening.\n You can leave by heading north or east.");  break;
        case 8: Console.WriteLine("This smartly decorated room was designed to house the guests of the castle.\nSeveral beds line the walls, and there are some chairs near a dresser.\nThis room has doors located to the north, east, and west.");  break;
        case 9: Console.WriteLine("The grand majesty of the master bedroom is quite a sight to behold.\nSilk sheets adorn a massive bed, alongside a walk in closet and personal washroom.\nYou can leave by going north or west.");  break;
    }
}
static void PlayError ()
{
    Console.WriteLine("Cannot move in that direction");
}
static void ShowMap (int coordinate)
{
    Console.WriteLine("1 2 3");
    Console.WriteLine("4 5 6");
    Console.WriteLine("7 8 9");
    Console.WriteLine($"You are in Room {coordinate}");
}
static int GeneratePercentage()
{
    return Random.Shared.Next(1, 101);
}
static void SeeShadows ()
{
    Console.WriteLine("As you open the door, a flicker of movement draws your eye.\nA shadowy figure exits the room through a different door silently.")
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