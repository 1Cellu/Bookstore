namespace Bookstore.BookAPI.Data.ValueObjects
{
    public class BookVO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Pages { get; set; }
        public string Author { get; set; }
        public int Inventory { get; set; }
    }
}
