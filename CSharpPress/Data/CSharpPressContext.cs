using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CSharpPress.Models
{
    public class CSharpPressContext : DbContext
    {
        public CSharpPressContext (DbContextOptions<CSharpPressContext> options)
            : base(options)
        {
        }

        public DbSet<CSharpPress.Models.Post> Post { get; set; }
    }
}
