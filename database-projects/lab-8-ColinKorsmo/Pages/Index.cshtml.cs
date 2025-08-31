using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using lab_8_ColinKorsmo.Models;

namespace lab_8_ColinKorsmo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly PatientDbContext _context;

        public IndexModel(PatientDbContext context)
        {
            _context = context;
        }

        public IList<Patient> Patients { get; set; } = new List<Patient>();

        public async Task OnGetAsync()
        {
            Patients = await _context.Patients.ToListAsync();
        }
    }

    public class CreateModel : PageModel
    {
        private readonly PatientDbContext _context;

        public CreateModel(PatientDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Patient Patient { get; set; } = new Patient();

        public IActionResult OnGet()
        {
            return Page();
        }

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

    public class DeleteModel : PageModel
    {
        private readonly PatientDbContext _context;

        public DeleteModel(PatientDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Patient Patient { get; set; } = new Patient(); // Initialize with a new Patient

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Patient = await _context.Patients.FindAsync(id);

            if (Patient == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            var patientToDelete = await _context.Patients.FindAsync(id);

            if (patientToDelete != null)
            {
                _context.Patients.Remove(patientToDelete);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
