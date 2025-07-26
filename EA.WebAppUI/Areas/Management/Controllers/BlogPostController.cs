using BLL.Abstract;
using Entity.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EA.WebAppUI.Areas.Management.Controllers
{
    public class BlogPostController : Controller
    {
        private readonly IBlogPostBLL _context;
        public readonly  IWebHostEnvironment _env;
        public BlogPostController(IBlogPostBLL context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var model = await _context.GetAllAsync();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(BlogPost blogPost)
        {
            if (ModelState.IsValid)
            {
                var result = _context.Add(blogPost);
                if (result)
                {
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError("", "Blog post could not be created.");
            }
            return View(blogPost);
        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            var blogPost = await _context.GetByIdAsync(id);
            if (blogPost == null)
            {
                return NotFound();
            }
            return View(blogPost);
        }
        [HttpPost]
        public async Task<IActionResult> Update(BlogPost blogPost)
        {
            if (ModelState.IsValid)
            {
                var result = _context.Update(blogPost);
                if (result)
                {
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError("", "Blog post could not be updated.");
            }
            return View(blogPost);
        }
    }
}
