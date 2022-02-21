using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiExercise.Models;

namespace WebApiExercise.Data
{
    public class WebApiExerciseContext : DbContext
    {
        public WebApiExerciseContext (DbContextOptions<WebApiExerciseContext> options)
            : base(options)
        {
        }

        public DbSet<WebApiExercise.Models.Student> Student { get; set; }
    }
}
