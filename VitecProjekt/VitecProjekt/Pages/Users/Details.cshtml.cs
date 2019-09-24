using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VitecProjekt.Model;
using VitecProjekt.Models;

namespace VitecProjekt.Pages.Users
{
    public class DetailsModel : PageModel
    {
        private readonly VitecProjekt.Models.VitecProjektContext _context;

        public DetailsModel(VitecProjekt.Models.VitecProjektContext context)
        {
            _context = context;
        }

        public User User { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User = await _context.User.FirstOrDefaultAsync(m => m.UserID == id);

            if (User == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
