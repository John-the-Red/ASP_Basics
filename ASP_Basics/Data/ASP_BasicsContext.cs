#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP_Basics.Models;

namespace ASP_Basics.Data
{
    public class ASP_BasicsContext : DbContext
    {
        public ASP_BasicsContext (DbContextOptions<ASP_BasicsContext> options)
            : base(options)
        {
        }

        public DbSet<ASP_Basics.Models.Movie> Movie { get; set; }
    }
}
