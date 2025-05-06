using Microsoft.AspNetCore.Mvc;
using Week2_2280601159.Models;
using Microsoft.EntityFrameworkCore;

namespace Week2_2280601159.Controllers
{
    public class ReviewController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReviewController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /Review
        public async Task<IActionResult> Index()
        {
            var reviews = await _context.ReviewPosts
                .OrderByDescending(r => r.CreatedAt)
                .ToListAsync();
            return View(reviews);
        }

        // GET: /Review/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Review/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Content")] ReviewPost reviewPost)
        {
            if (ModelState.IsValid)
            {
                reviewPost.CreatedAt = DateTime.Now;
                _context.Add(reviewPost);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(reviewPost); // Giữ lại dữ liệu khi có lỗi
        }

        // GET: /Review/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var post = await _context.ReviewPosts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (post == null) return NotFound();

            return View(post);
        }
    }
}
