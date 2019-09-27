using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VitecProjekt.Model;
using VitecProjekt.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

namespace VitecProjekt.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly VitecProjekt.Models.VitecProjektContext _context;

        public IndexModel(VitecProjekt.Models.VitecProjektContext context, ILogger<IndexModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        private readonly ILogger _logger;

        //public IndexModel(ILogger<IndexModel> logger)
        //{
        //    _logger = logger;
        //}

        public IList<User> User { get;set; }
        public string Message { get; set; }

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
            Message = $"Index page visited at {DateTime.UtcNow.ToLongTimeString()}";
            _logger.LogInformation("Message displayed: {Message}", Message);
        }
    }
}
