using System;
using System.Collections.Generic;

namespace CRUDApi.DataContext
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime? BirthDt { get; set; }
        public string? HomeAddress { get; set; }
    }
}
