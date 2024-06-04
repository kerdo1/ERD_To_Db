using System;
using System.Collections.Generic;

namespace DatabaseTask.Models
{
    public partial class Product
    {
        public int? Id { get; set; }
        public string? ProductName { get; set; }
        public int? Quantity { get; set; }
    }
}
