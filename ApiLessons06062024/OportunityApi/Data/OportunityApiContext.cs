using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace OportunityApi.Data
{
    public class OportunityApiContext : DbContext
    {
        public OportunityApiContext (DbContextOptions<OportunityApiContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Oportunity> Oportunity { get; set; } = default!;
    }
}
