using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using web_api_1.models;

namespace web_api_1.Data
{
    public class web_api_1Context : DbContext
    {
        public web_api_1Context (DbContextOptions<web_api_1Context> options)
            : base(options)
        {
        }

        public DbSet<web_api_1.models.Employee> Employee { get; set; }
    }
}
