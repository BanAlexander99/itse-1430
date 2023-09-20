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

        //Methods - functions
        /// <summary>
        /// Download metadata from Internet.
        /// </summary>
        /// <remarks>
        /// Searches IMDB and TheTVDB.com.
        /// </remarks>
        private void DownloadMetadata ()
        { }
        /// <summary>
        /// Validates the movie instance.
        /// </summary>
        /// <returns>Error message if invalid or empty string otherwise.</returns>
        public string Validate () /* Movie this */
        {
            //Title is required
            //if (String.IsNullOrEmpty(this.title))
            if (String.IsNullOrEmpty(title))
                return "Title is required";

           
            //error;

            //Release Year >= 1900
            if (releaseYear < 1900)
                return "Release Year must be >= 1900";
            //Length >= 0
            if (length <0)
                return "Length must be at least 0";
            //TODO: Rating is in a list

            //If ReleaseYear < 1940 then IsBlackAndWhite must be true
            if (releaseYear < 1940 && !isBlackAndWhite)
                return "Movies before 1940 must be black and white";

            //Valid
            return "";
        }
       
    }
}