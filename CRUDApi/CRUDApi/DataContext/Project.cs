using System;
using System.Collections.Generic;

namespace CRUDApi.DataContext
{
    public partial class Project
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? ClientId { get; set; }
        public DateTime? StartDt { get; set; }
        public DateTime? Enddate { get; set; }

        public virtual Client? Client { get; set; }
    }
}
