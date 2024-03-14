using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace assignment2.Models;

[Table("shippers")]
public partial class Shipper
{
    [Key]
    [Column("shipper_id")]
    public int ShipperId { get; set; }

    [Column("company_name")]
    [StringLength(40)]
    public string CompanyName { get; set; } = null!;

    [Column("phone")]
    [StringLength(24)]
    public string? Phone { get; set; }

    [InverseProperty("ShipViaNavigation")]
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
