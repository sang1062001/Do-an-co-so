using System.ComponentModel.DataAnnotations;

namespace BanHangDienTu.Models
{
    public class ProductTypes
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Loại sản phẩm")]
        public string ProductType { get; set; }
    }
}
