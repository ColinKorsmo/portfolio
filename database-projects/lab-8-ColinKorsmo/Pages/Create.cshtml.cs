using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using lab_8_ColinKorsmo.Models;
using System.Threading.Tasks;

namespace lab_8_ColinKorsmo
{
    public class CreateModel : PageModel
    {
        private readonly PatientDbContext _context;

        public CreateModel(PatientDbContext context)
        {
            _context = context;
            Patient = new Patient();
        }

        [BindProperty]
        public Patient Patient { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Patients.Add(Patient);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
