using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagment.Data.Enteties
{
    public class CustomerEntity
    {
        [Key]
        public int id { get; set; }

        public string name { get; set; }
        required

        public DateTime? customer_since { get; set; }

        public int? project_id { get; set; }

        public int? employee_id { get; set; }

    }

}

