using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webApplication2.Models;

namespace webApplication2.Data
{
    public class webApplication2Context : DbContext
    {
        public webApplication2Context (DbContextOptions<webApplication2Context> options)
            : base(options)
        {
        }

        public DbSet<webApplication2.Models.Movie> Movie { get; set; } = default!;
    }
}
