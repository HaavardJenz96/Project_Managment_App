using ProjectManagment.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagment.Data.Enteties
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(255)]
        public string Name { get; set; }

        [Column("customer_since")]
        public DateTime? CustomerSince { get; set; }

        public DateTime Created { get; set; } = DateTime.UtcNow;
        public DateTime? Updated { get; set; }
        [MaxLength(255)]
        public string UpdatedBy { get; set; }

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
        public ICollection<Project> Projects { get; set; } = new List<Project>();

    }

}

