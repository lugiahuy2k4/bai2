using System;
using System.ComponentModel.DataAnnotations;

namespace Week2_2280601159.Models
{
    public class ReviewPost
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tiêu đề không được để trống")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Nội dung không được để trống")]
        public string Content { get; set; }

        public string Author { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}

