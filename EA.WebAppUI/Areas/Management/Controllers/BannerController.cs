using BLL.Abstract;
using Entity.Entities;
using KB.MindShift.WebUI.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EA.WebAppUI.Areas.Management.Controllers
{
    [Area("Management")]
    public class BannerController : Controller
    {
        private readonly IHeaderBLL _context;
        private readonly IWebHostEnvironment _env;

        public BannerController(IHeaderBLL context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;

        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var headers = await _context.GetAllAsync();
            return View(headers);
        }
        [HttpGet]
        public IActionResult Create()
        {
             // Assuming you want to create a new header with an empty ID
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Header header, IFormFile image)
        {
            if (ModelState.IsValid)
            {
                if (image != null)
                {
                    header.ImageUrl = await FileUploader.UploadAsync(_env, image);
                    header.IsActive = true;
                    _context.Add(header);
                }

                Header? existingModel = await _context.GetByIdAsync(header.Id);
                bool result = false;
                if (existingModel != null)
                {
                    result = _context.Update(header);
                }
                else
                {
                    result = _context.Add(header);
                }

            }
            return View(header);
        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            var header = await _context.GetByIdAsync(id);
            if (header == null)
            {
                return NotFound();
            }
            return View(header);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Header header, IFormFile image)
        {
            if (ModelState.IsValid)
            {
                if (image != null)
                {
                    await FileUploader.DeleteAsync(_env, header.ImageUrl);
                    header.ImageUrl = await FileUploader.UploadAsync(_env, image);
                }

                _context.Update(header);
                return RedirectToAction(nameof(Index));
            }
            return View(header);
        }

        [HttpPost]
        public async Task<JsonResult> Delete(Guid id)
        {
            var header = await _context.GetByIdAsync(id);
            if (header == null)
                return Json(new { success = false, message = "Ürün Resmi Bulunamadı" });

            await FileUploader.DeleteAsync(_env, header.ImageUrl);
            bool result = _context.Delete(id);
            if (!result)
                return Json(new { success = false, message = "Silinemedi!" });


            return Json(new { success = true, message = "Ürün Resmi Silindi!" });


        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Activate(Guid id)
        {
            var header = await _context.Activate(id);
            if (header == null)
            {
                return NotFound();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
