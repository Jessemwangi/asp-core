using System.ComponentModel.DataAnnotations;

namespace CoreWithViews.models
{
    public class Category
    {
        [Required]
        public long Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}
