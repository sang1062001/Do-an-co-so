using System.ComponentModel.DataAnnotations;

namespace BanHangDienTu.Areas.Admin.Models
{
    public class RoleUserVm
    {
        [Required]
        [Display(Name = "Người dùng")]
        public string UserId { get; set; }
        [Required]
        [Display(Name = "vai trò")]
        public string RoleId { get; set; }

    }
}
