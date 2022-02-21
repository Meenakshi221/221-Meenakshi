using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_10.Models;

namespace MVC_10.Data
{
    public class MVC_10Context : DbContext
    {
        public MVC_10Context (DbContextOptions<MVC_10Context> options)
            : base(options)
        {
        }

        public DbSet<MVC_10.Models.Employee> Employee { get; set; }
    }
}
