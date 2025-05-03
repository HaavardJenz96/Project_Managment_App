using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagment.Data.Entities
{
    public class WBS
    {
        public int Id { get; set; }

        public int? ParentWbsId { get; set; }
        public WBS ParentWBS { get; set; }
        public ICollection<WBS> SubWBSItems { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public int WbsLevel { get; set; }

        [Required, MaxLength(255)]
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public int? ProgressId { get; set; }
        public Progress Progress { get; set; }

        public DateTime Created { get; set; } = DateTime.UtcNow;
        public DateTime? Updated { get; set; }
        [MaxLength(255)]
        public string UpdatedBy { get; set; }
    }
}
