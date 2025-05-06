using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Week2_2280601159.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string? Name { get; set; }
        public string? Author { get; set; }
        [Column(TypeName = "Decimal(18,2)")]
        [Range(0.01, 50000.00)]
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public int CategoryId { get; set; }
        // Các thuộc tính hiện có
        public string? ImageUrl { get; set; } // Đường dẫn đến hình ảnh đại diện
        public List<string>? ImageUrls { get; set; } // Danh sách các hình ảnh khác
    }
}

