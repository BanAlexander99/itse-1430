//  Movie Data:
//  Title, genre, description, MPAA rating
//  Length, Release year, budget
//  IsBlackAndWhite
//  Operations: Add, edit, view, delete


using MovieLibrary;

namespace MovieLibrary.ConsoleHost;

partial class Program
{
    static void Main ()
    {
        var app = new Program();
        app.Run ();
    }

    void Run ()
    { 
        //TODO: Remove this
        Movie movie = new Movie();

        //Entry Point
        var done = false;
        do
        {

            switch (DisplayMenu())
            {

                case MenuCommand.Add: movie = AddMovie(); break;
                case MenuCommand.Edit: EditMovie(); break;
                case MenuCommand.Delete:
                {
                    //TODO: Clean this up
                    if (DeleteMovie(movie))
                        movie = new Movie();
                    break;
                };
                case MenuCommand.View: ViewMovie(movie); break;
                case MenuCommand.Quit:
                {
                    done = true;
                    break;
                };
                default: Console.WriteLine("Unknown option"); break;
            };
        } while (!done);
    }

    //Get movie details and display


    /// Functions
    /// 


    MenuCommand DisplayMenu ()
    {

        Console.WriteLine("------------");
        Console.WriteLine("A)dd Movie");
        Console.WriteLine("E)dit Movie");
        Console.WriteLine("D)elete Movie");
        Console.WriteLine("V)iew Movie");
        Console.WriteLine("Q)uit");

        do
        {
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.A: return MenuCommand.Add;
                case ConsoleKey.E: return MenuCommand.Edit;
                case ConsoleKey.D: return MenuCommand.Delete;
                case ConsoleKey.V: return MenuCommand.View;
                case ConsoleKey.Q: return MenuCommand.Quit;
            }
        } while (true);
    }

    //Get a new movie
    Movie AddMovie ()
    {
        var movie = new Movie();

        do
        {



            movie.Title = ReadString("Enter a title: ", true);
            movie.Description = ReadString("Enter a description: ", false);

            movie.RunLength = ReadInt("Enter the run length (in mins): ", 0);
            movie.ReleaseYear = ReadInt("Enter the release year: ", 1900);

            movie.Genre = ReadString("Enter a genre: ", false);
            movie.Rating = ReadRating("Enter a rating: ");

            movie.IsBlackAndWhite = ReadBoolean("Black and White (Y/N)?");

            //Validate
            var error = movie.Validate();
            if (String.IsNullOrEmpty(error))
                return movie;

            Console.WriteLine($"ERROR: {error}");
        } while (true);

    }

    void EditMovie ()
    {
        Console.WriteLine("Not implemented yet.");
    }

    bool DeleteMovie ( Movie movie )
    {
        if (String.IsNullOrEmpty(movie.Title))
            return false;

        if (!Confirm($"Are you sure you want to delete the movie '{movie.Title}' (Y/N)?"))
            return false;

        //TODO: Delete movie
        //title = "";
        return true;
    }

    //Display the movie details
    void ViewMovie ( Movie movie )
    {
        if (String.IsNullOrEmpty(movie.Title))

        //movie.DownloadMetadata();
        {
            //Length of a string
            int len = movie.Title.Length;
            Console.WriteLine("No movies available");
            return;
        };


        Console.WriteLine("".PadLeft(15, '-'));

        Console.WriteLine(movie.Title);


        string message = $"Run Length {movie.RunLength} mins";
        Console.WriteLine(message);
        if (movie.NeedsIntermission)
            Console.WriteLine("Includes intermission");


        Console.WriteLine($"Released {movie.ReleaseYear}");

        Console.WriteLine(movie.Genre);


        Console.WriteLine($"MPAA RAting: {movie.Rating}");


        //V2
        string format = movie.IsBlackAndWhite ? "Black and White" : "Color";
        Console.WriteLine("Format: " + format);

        //V3


        Console.WriteLine(movie.Description);


    }
    ///<summary></summary>
    bool Confirm ( string message )
    {
        return ReadBoolean(message);
    }
    /// <summary>
    /// Reads a boolean value.</summary>
    /// <param name="message">Message to show.</param>
    /// <returns>Returns true if the value was true or false otherwise.</returns>
    bool ReadBoolean ( string message )
    {
        Console.WriteLine(message);

        //Handle errors
        while (true)
        {

            switch (Console.ReadKey(true).Key)
            {

                case ConsoleKey.Y: return true;


                case ConsoleKey.N: return false;
            };

        };
    }



    int ReadInt ( string message, int minimumValue )
    {
        Console.WriteLine(message);

        do
        {
            string value = Console.ReadLine();

            if (Int32.TryParse(value, out var result))
                if (result >= minimumValue)
                    return result;

            Console.WriteLine("Value must be at least " + minimumValue);
        } while (true);
    }

    string ReadString ( string message, bool isRequired )
    {
        Console.WriteLine(message);

        do
        {
            string value = Console.ReadLine().Trim();

            if (!isRequired || !String.IsNullOrEmpty(value))
                return value;

            Console.WriteLine("Value is required");
        } while (true);
    }

    string ReadRating ( string message )
    {
        Console.WriteLine(message);

        do
        {
            string value = Console.ReadLine();


            if (String.Equals(value, "PG", StringComparison.CurrentCultureIgnoreCase))
                return "PG";
            else if (String.Equals(value, "G", StringComparison.CurrentCultureIgnoreCase))
                return "G";
            else if (String.Equals(value, "PG-13", StringComparison.CurrentCultureIgnoreCase))
                return "PG-13";
            else if (String.Equals(value, "R", StringComparison.CurrentCultureIgnoreCase))
                return "R";

            else if (String.IsNullOrEmpty(value))
                return "";

            Console.WriteLine("Invalid rating");
        } while (true);


    }
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