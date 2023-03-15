using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BanHangDienTu.Models
{
    public class Products
    {
        [Display(Name = "Mã sản phẩm")]
        public int Id { get; set; }
        [Required]
        [Display(Name ="Tên sản phẩm")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Giá sản phẩm")]
        public decimal Price { get; set; }
        [Display(Name ="Ảnh sản phẩm")]
        public string Image { get; set; }
        [Display(Name = "Màu sản phẩm")]
        public string ProductColor { get; set; }
        [Required]
        [Display(Name = "Trình trạng còn hàng")]
        public bool IsAvailable { get; set; }

        [Display(Name = "Loại sản phẩm")]
        [Required]
        public int ProductTypeId { get; set; }
        [ForeignKey("ProductTypeId")]
        public virtual ProductTypes ProductTypes { get; set; }
        [Display(Name = "Hãng")]
        [Required]
        public int SpecialTagId { get; set; }
        [ForeignKey("SpecialTagId")]
        public virtual SpecialTag SpecialTag { get; set; }

    }
}
