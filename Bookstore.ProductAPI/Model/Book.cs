using GeekShopping.ProductAPI.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookstore.BookAPI.Model
{
    [Table("book")]
    public class Book : BaseEntity
    {
        [Column("name")]
        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Column("price")]
        [Required]
        [Range(1,10000)]
        public decimal Price { get; set; }

        [Column("description")]
        [StringLength(500)]
        public string Description { get; set; }

        [Column("pages")]
        [Required]
        public int Pages { get; set; }

        [Column("author")]
        [Required]
        [StringLength(150)]
        public string Author { get; set; }
    }
}
