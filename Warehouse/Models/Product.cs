﻿using System;

namespace Warehouse.Models
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal CostPrice { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
    }
}
