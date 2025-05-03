using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagment.Data.Entities
{
    public class Progress
    {
        public int Id { get; set; }

        public int StatusId { get; set; }
        public Status Status { get; set; }

        [Range(0, 100)]
        public int PercentageComplete { get; set; }

        public DateTime? LastUpdated { get; set; }
        public DateTime Created { get; set; } = DateTime.UtcNow;
        public DateTime? Updated { get; set; }
        [MaxLength(255)]
        public string UpdatedBy { get; set; }

        public ICollection<Project> Projects { get; set; }
        public ICollection<WBS> WBSItems { get; set; }

    }
}
