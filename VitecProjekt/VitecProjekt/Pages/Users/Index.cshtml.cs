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
    public class IndexModel : PageModel
    {
        private readonly VitecProjekt.Models.VitecProjektContext _context;

        public IndexModel(VitecProjekt.Models.VitecProjektContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
