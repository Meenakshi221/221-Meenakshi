using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineProductStore.Models;

namespace OnlineProductStore.Data
{
    public class OrdersContext : DbContext
    {
        public OrdersContext (DbContextOptions<OrdersContext> options)
            : base(options)
        {
        }

        public DbSet<OnlineProductStore.Models.Product> Product { get; set; }

        public DbSet<OnlineProductStore.Models.Order> Order { get; set; }

        public DbSet<OnlineProductStore.Models.OrderDetail> OrderDetail { get; set; }

        public DbSet<OnlineProductStore.Models.User> User { get; set; }
    }
}
