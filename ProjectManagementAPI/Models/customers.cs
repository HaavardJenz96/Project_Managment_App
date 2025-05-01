using System.ComponentModel.DataAnnotations;

public class Customer
{
    [Key]
    public int id { get; set; }

    public string name { get; set; }

    public DateTime? customer_since { get; set; }

    public int? project_id { get; set; }

    public int? employee_id { get; set; }
}

