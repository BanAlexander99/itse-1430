namespace MovieLibrary
{
    /// <summary> Represents a movie.</summary>
    /// <remarks>
    /// Paragraphs of descriptions.
    /// </remarks>
    public class Movie
    {
        //Fields - data
        /// <summary>Title of movie.</summary>
        public string title = "";
        /// <summary>Description of movie.</summary>
        public string description = "";
        /// <summary>Genre of movie.</summary>
        public string genre = "";
        /// <summary>Rating of movie.</summary>
        public string rating = "";

        /// <summary>Movie runtime (in minutes).</summary>
        public int length;
        /// <summary>Movie release year.</summary>
        public int releaseYear = 1900;
        /// <summary>Is the movie in black and white?</summary>
        public bool isBlackAndWhite;
    }
}