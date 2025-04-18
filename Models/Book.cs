namespace BookManagementAPI.Models
{
    public class Book
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Author { get; set; }
        public int Year { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}