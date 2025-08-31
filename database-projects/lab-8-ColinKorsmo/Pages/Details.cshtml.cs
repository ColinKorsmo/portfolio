using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using lab_8_ColinKorsmo.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace lab_8_ColinKorsmo
{
    public class DetailsModel : PageModel
    {
        private readonly PatientDbContext _context;

        public DetailsModel(PatientDbContext context)
        {
            _context = context;
        }

        public Patient? Patient { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Patient = await _context.Patients.FindAsync(id);

            if (Patient == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
