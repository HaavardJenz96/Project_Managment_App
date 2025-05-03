using ProjectManagment.Data.Enteties;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagment.Data.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public ICollection<ProjectAssignment> ProjectAssignments { get; set; } = new List<ProjectAssignment>();

        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }
    }
}
