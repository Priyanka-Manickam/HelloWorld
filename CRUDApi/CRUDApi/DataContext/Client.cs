using System;
using System.Collections.Generic;

namespace CRUDApi.DataContext
{
    public partial class Client
    {
        public Client()
        {
            Projects = new HashSet<Project>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
    }
}
