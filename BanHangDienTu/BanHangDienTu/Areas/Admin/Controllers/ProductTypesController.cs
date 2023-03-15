using BanHangDienTu.Data;
using BanHangDienTu.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace BanHangDienTu.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles ="Super user")]
    public class ProductTypesController : Controller
    {
        private ApplicationDbContext _db;

        public ProductTypesController(ApplicationDbContext db)
        {
            _db = db;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            //var data = _db.ProductTypes.ToList();
            return View(_db.ProductTypes.ToList());
        }

        // tạo

        public ActionResult Create()
        {
            return View();
        }

        // post tạo
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductTypes ProductTypes )
        {
            if(ModelState.IsValid)
            {
                _db.ProductTypes.Add(ProductTypes);
                await _db.SaveChangesAsync();
                TempData["save"] = "Loại sản phẩm đã được lưu";
                return RedirectToAction(actionName:nameof(Index));
            }
            return View(ProductTypes);
        }

        // sửa
        public ActionResult Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var ProductType = _db.ProductTypes.Find(id);
            if(ProductType == null)
            {
                return NotFound();
            }
            return View(ProductType);
        }

        // post sửa
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProductTypes ProductTypes)
        {
            if (ModelState.IsValid)
            {
                _db.Update(ProductTypes);
                await _db.SaveChangesAsync();
                TempData["edit"] = "Loại sản phẩm đã được cập nhật";
                return RedirectToAction(actionName: nameof(Index));
            }
            return View(ProductTypes);
        }


        // chi tiết
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var ProductType = _db.ProductTypes.Find(id);
            if (ProductType == null)
            {
                return NotFound();
            }
            return View(ProductType);
        }

        // post chi tiết
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Details(ProductTypes ProductTypes)
        {
            
                return RedirectToAction(actionName: nameof(Index));
            
        }


        // xóa
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var ProductType = _db.ProductTypes.Find(id);
            if (ProductType == null)
            {
                return NotFound();
            }
            return View(ProductType);
        }

        // post xóa
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id, ProductTypes ProductTypes)
        {
            if(id==null)
            {
                return NotFound();
            }
            if(id!=ProductTypes.Id)
            {
                return NotFound();
            }

            var productType = _db.ProductTypes.Find(id);
            if(productType==null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _db.Remove(productType);
                await _db.SaveChangesAsync();
                TempData["delete"] = "Loại sản phẩm đã được xóa";
                return RedirectToAction(actionName: nameof(Index));
            }
            return View(ProductTypes);
        }
    }
}
