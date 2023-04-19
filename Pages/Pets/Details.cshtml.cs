using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AssignProject.Models;

namespace AssignProject.Pages.Pets
{
    public class DetailsModel : PageModel
    {
        private readonly AssignProject.Models.Context _context;

        public DetailsModel(AssignProject.Models.Context context)
        {
            _context = context;
        }

      public Pet Pet { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(uint? id)
        {
            if (id == null || _context.Pet == null)
            {
                return NotFound();
            }

            var pet = await _context.Pet.FirstOrDefaultAsync(m => m.PetId == id);
            if (pet == null)
            {
                return NotFound();
            }
            else 
            {
                Pet = pet;
            }
            return Page();
        }
    }
}
