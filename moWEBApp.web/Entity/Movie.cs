namespace moWEBApp.web.Entity
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Director { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ImageUrl { get; set; }
        public Genre Genre { get; set; }
        public int? GenreId { get; set; }
        public string TrailerLink { get; set; }
    }
}
