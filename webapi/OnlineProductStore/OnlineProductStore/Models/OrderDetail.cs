﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineProductStore.Models
{
    public class OrderDetail
    {

        [Key]
        public int OrderDetailsID { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        public int ProductAmount { get; set; }

        public Product Product { get; set; }
        public Order Order { get; set; }

    }
}
