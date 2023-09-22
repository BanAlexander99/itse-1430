//  Movie Data:
//  Title, genre, description, MPAA rating
//  Length, Release year, budget
//  IsBlackAndWhite
//  Operations: Add, edit, view, delete

namespace MovieLibrary.ConsoleHost;

enum MenuCommand
{
    Add = 1,
    Edit,
    Delete,
    View,
    Quit = 0
}
//Ways to represent an empty string
/// 1. ""
/// 2. String.Empty
/// 3. unassigned string variable is given special value null **NIGHTMARE**
/// null != empty
//double someFloatingValue = 3.14159;
//char letterGrade = 'A';

//{
//    int hours = 5;
//    //int title = 54;
//    title = "Jaws";

//    Console.WriteLine(title);
//    Console.WriteLine(length);
//}