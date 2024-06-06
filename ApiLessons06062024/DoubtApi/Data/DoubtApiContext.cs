using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DoubtApi.Data
{
    public class DoubtApiContext : DbContext
    {
        public DoubtApiContext (DbContextOptions<DoubtApiContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Doubt> Doubt { get; set; } = default!;
    }
}
