using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagment.Data.Entities
{
    public class Status
    {
        public int Id { get; set; }

        [Required, MaxLength(255)]
        public string Name { get; set; }

        public ICollection<Progress> Progresses { get; set; }
    }
}
