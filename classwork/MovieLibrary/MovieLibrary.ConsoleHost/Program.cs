//  Movie Data:
//  Title, genre, description, MPAA rating
//  Length, Release year, budget
//  IsBlackAndWhite
//  Operations: Add, edit, view, delete

string title = "", description = "";
//title = "";
string genre = "", rating = "";

int length = 0, releaseYear = 1900;

decimal budget = 125.45M;
bool isBlackAndWhite = false;

//Get movie details and display
GetMovie();
DisplayMovie();

/// Functions
void GetMovie ()
{
    title = ReadString("Enter a title: ", true);
    description = ReadString("Enter a description: ", false);

    //TODO: Fix length
    length = ReadInt("Enter the run length (in mins): ", 0);
    releaseYear = ReadInt("Enter the release year: ", 1900);
}

void DisplayMovie ()
{
    Console.WriteLine(title);
    Console.WriteLine(description);
    Console.WriteLine(length);
}

int ReadInt ( string message, int minimumValue )
{
    Console.WriteLine(message);

    string value = Console.ReadLine();
    //NOT SAFE
    //int result = Int32.Parse(value);
    int result;
    if (Int32.TryParse(value, out result))
        if (result >= minimumValue)
            return result;
    //TODO: Input validation
    return 0;

}
string ReadString ( string message, bool isRequired )
{
    Console.WriteLine(message);
    string value = Console.ReadLine();

    if (!isRequired)
        return value;
    //else
    //    return "";
    //return Console.ReadLine();
    //TODO: Input validation for required
    return value;
    //if (false)
    //{
    //    if (true)
    //        Console.WriteLine();

    //} else

}
//double someFloatingValue = 3.14159;
//char letterGrade = 'A';

//{
//    int hours = 5;
//    //int title = 54;
//    title = "Jaws";

//    Console.WriteLine(title);
//    Console.WriteLine(length);
//}