using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Exercise2.Models;

namespace Exercise2.Data
{
    public class Exercise2Context : DbContext
    {
        public Exercise2Context (DbContextOptions<Exercise2Context> options)
            : base(options)
        {
        }

        public DbSet<Exercise2.Models.Student> Student { get; set; }
    }
}
