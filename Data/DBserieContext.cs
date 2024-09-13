using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Apiserie.Models;

namespace Apiserie.Data
{
    public class DBserieContext : DbContext
    {
        public DBserieContext (DbContextOptions<DBserieContext> options)
            : base(options)
        {
        }

        public DbSet<Apiserie.Models.serie> serie { get; set; } = default!;
    }
}
