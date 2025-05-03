using ProjectManagment.Data.Enteties;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagment.Data.Entities
{
    public class Project
    {

        public int Id { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        [Required, MaxLength(255)]
        public string ProjectName { get; set; }

        public int? ProjectManagerId { get; set; }
        public Employee ProjectManager { get; set; }

        [MaxLength(1000)]
        public string ProjectDescription { get; set; }

        public DateTime? ProjectStart { get; set; }
        public DateTime? ProjectEnd { get; set; }

        public int? ProgressId { get; set; }
        public Progress Progress { get; set; }

        public DateTime Created { get; set; } = DateTime.UtcNow;
        public DateTime? Updated { get; set; }
        [MaxLength(255)]
        public string UpdatedBy { get; set; }

        public ICollection<WBS> WBSItems { get; set; }
    }
}
