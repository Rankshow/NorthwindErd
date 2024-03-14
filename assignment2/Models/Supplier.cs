using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace assignment2.Models;

[Table("suppliers")]
[Index("CompanyName", Name = "company_name")]
[Index("PostalCode", Name = "postal_code")]
public partial class Supplier
{
    [Key]
    [Column("supplier_id")]
    public int SupplierId { get; set; }

    [Column("company_name")]
    [StringLength(40)]
    public string CompanyName { get; set; } = null!;

    [Column("contact_name")]
    [StringLength(30)]
    public string? ContactName { get; set; }

    [Column("contact_title")]
    [StringLength(30)]
    public string? ContactTitle { get; set; }

    [Column("address")]
    [StringLength(60)]
    public string? Address { get; set; }

    [Column("city")]
    [StringLength(15)]
    public string? City { get; set; }

    [Column("region")]
    [StringLength(15)]
    public string? Region { get; set; }

    [Column("postal_code")]
    [StringLength(10)]
    public string? PostalCode { get; set; }

    [Column("country")]
    [StringLength(15)]
    public string? Country { get; set; }

    [Column("phone")]
    [StringLength(24)]
    public string? Phone { get; set; }

    [Column("fax")]
    [StringLength(24)]
    public string? Fax { get; set; }

    [Column("home_page")]
    [StringLength(100)]
    public string? HomePage { get; set; }

    [InverseProperty("Supplier")]
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
