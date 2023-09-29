namespace MovieLibrary
{
    /// <summary>Represents a movie.</summary>
    /// <remarks>
    /// Additional remarks to help when using the class.
    /// </remarks>
    public class Movie : ValidatableObject
    {
        //Fields - data

        private string _title;
        private string _description;
        private string _genre;
        private string _rating;
        private bool _initialized;
        //Default constructor
        public Movie ()
        {
            _initialized = true;
        }
        /// <summary>
        ///  Initializes the Movie Class
        /// </summary>
        /// <param name="id">Identifier of the movie.</param>"
        public Movie ( int id ) : this(id, "")
        {
            //Initialize(id, "");
        }

        public Movie ( string title ) : this(0, title)
        {
            //Initialize(0, title);
        }
        public Movie ( int id, string title ) : this()
        {

            //Initialize(id, title);
            ID = id;
            Title = title;
        }

        //Full property syntax
        //private int _length;
        //private int _releaseYear = 1900;
        //private bool _isBlackAndWhite;

        //Properties - data with functionality

        /// <summary>Title of movie.</summary>

        public int ID
        {
            get;
            private set;
        }
        public string Title
        {
            //string get()
            get {
                if (String.IsNullOrEmpty(_title))
                    return "";

                return _title;
            }

            //void set(string value)
            set {
                if (value != null)
                    value = value.Trim();

                _title = value;
            }
        }

        /// <summary>Description of movie.</summary>
        public string Description
        {
            get {
                if (String.IsNullOrEmpty(_description))
                    return "";
                return _description;
            }
            set {
                _description = value;
            }
        }

        /// <summary>Genre of movie.</summary>
        public string Genre
        {
            get {
                if (String.IsNullOrEmpty(_genre))
                    return "";
                return _genre;
            }
            set {
                _genre = value;
            }
        }

        /// <summary>Rating of movie.</summary>
        public string Rating
        {
            get {
                if (String.IsNullOrEmpty(_rating))
                    return "";
                return _rating;
            }
            set {
                _rating = value;
            }
        }

        /// <summary>Movie runtime (in minutes).</summary>
        //Full property syntax
        //public int RunLength
        //{
        //    get { return _length; }
        //    set { _length = value; }
        //}
        public int RunLength { get; set; }

        /// <summary>Movie release year.</summary>
        //public int ReleaseYear
        //{
        //    get { return _releaseYear; }
        //    set {
        //        _releaseYear = value;
        //    }
        //}
        public int ReleaseYear { get; set; } = 1900;
        /// <summary>Is the movie in black and white?</summary>
        //public bool IsBlackAndWhite
        //{
        //    get { return _isBlackAndWhite; }
        //    set { _isBlackAndWhite = value; }
        //}
        public bool IsBlackAndWhite { get; set; }

        public bool NeedsIntermission
        {
            //Runlength > 150
            get { return RunLength >= 150; }
            //set { }
        }
        //Methods - functions
        /// <summary>
        /// Download metadata from Internet.
        /// </summary>
        /// <remarks>
        /// Searches IMDB and TheTVDB.com.
        /// </remarks>
        private void DownloadMetadata ()
        {
            //Initialize(0, "");
        }

        /// <summary>
        /// Validates the movie instance.
        /// </summary>
        /// <returns>Error message if invalid or empty string otherwise.</returns>
        public override bool TryValidate ( out string message ) /* Movie this */
        {
            //Title is required
            //if (String.IsNullOrEmpty(this.title))
            if (String.IsNullOrEmpty(_title))
            {

                message =  "Title is required";
                return false;
            }
            //error;

            //Release Year >= 1900
            if (ReleaseYear < 1900)
            {

                message = "Release Year must be >= 1900";
                return false;
            }
            //Length >= 0
            if (RunLength <0)
            {
                message = "Length must be at least 0";
                return false;
            }
            //TODO: Rating is in a list

            //If ReleaseYear < 1940 then IsBlackAndWhite must be true
            if (ReleaseYear < 1940 && !IsBlackAndWhite)
            {
                message = "Movies before 1940 must be black and white";
                return false;
            }

            //Valid
            message = "";
            return true;
        }



    }
}
