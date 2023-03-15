using System.ComponentModel.DataAnnotations;

namespace BanHangDienTu.Models
{
    public class SpecialTag
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Tên Hãng")]
        public string Name { get; set; }

    }
}
