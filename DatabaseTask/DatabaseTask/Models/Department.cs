using System;
using System.Collections.Generic;

namespace DatabaseTask.Models
{
    public partial class Department
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }
        public int? Workers { get; set; }
    }
}
