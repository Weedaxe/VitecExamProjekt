using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VitecProjekt.Model;

namespace VitecProjekt.Models
{
    public class VitecProjektContext : DbContext
    {
        public VitecProjektContext (DbContextOptions<VitecProjektContext> options)
            : base(options)
        {
        }

        public DbSet<VitecProjekt.Model.User> User { get; set; }
    }
}
