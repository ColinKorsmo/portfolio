using homework_6_ColinKorsmo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace homework_6_ColinKorsmo.Pages
{
    public class AddReviewModel : PageModel
    {
        private readonly AppDbContext _context;

        public AddReviewModel(AppDbContext context)
        {
            _context = context;
        }

        public List<Product> Products { get; set; } = new List<Product>();

        [BindProperty]
        public int ProductID { get; set; }

        [BindProperty]
        public int Score { get; set; }

        [BindProperty]
        public string ReviewText { get; set; } = string.Empty;

        public async Task OnGetAsync()
        {
            Products = await _context.Products.ToListAsync();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var review = new Review
            {
                ProductID = ProductID,
                Score = Score,
                ReviewText = ReviewText
            };

            _context.Reviews.Add(review);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Index");
        }
    }
}
