using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectManagment.Data.Entities
{
    public class ViewProjectStatus
    {
        [Column("project_name")]
        public string ProjectName { get; set; }
        
        [Column("project_description")]
        public string ProjectDescription { get; set; }
       
        [Column("project_start")]
        public DateTime ProjectStart { get; set; }
        
        [Column("percentage_complete")]
        public int PercentageComplete { get; set; }

        [Column("name")]
        public string Name { get; set; } 

    }
}
