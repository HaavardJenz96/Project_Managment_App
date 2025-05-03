using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagment.Data.Entities
{
    [Keyless]
    public class ViewAccountManagers
    {
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Full_Name { get; set; }
        public string Email { get; set; }
        public DateTime Birth_Date { get; set; }
    }
}
