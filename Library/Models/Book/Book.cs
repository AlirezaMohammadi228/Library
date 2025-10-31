namespace Library.Models.Book
{
    public enum BookGenre
    {
        None = 0,
        Novel = 1,
        Scientific = 2,

    }
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public BookGenre BookGenre { get; set; }
        public int Quantity { get; set; }
        public bool IsAvailable { get; set; }
        public int Id { get; set; }
        private static int _id = 1;
        public Book()
        {
            Id = _id++;
            IsAvailable = true;
        }

    }
}
