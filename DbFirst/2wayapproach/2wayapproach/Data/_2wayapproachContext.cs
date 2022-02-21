using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _2wayapproach.Models;

namespace _2wayapproach.Data
{
    public class _2wayapproachContext : DbContext
    {
        public _2wayapproachContext (DbContextOptions<_2wayapproachContext> options)
            : base(options)
        {
        }

        public DbSet<_2wayapproach.Models.University> University { get; set; }
    }
}
