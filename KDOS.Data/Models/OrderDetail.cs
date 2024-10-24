﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace KDOS.Data.Models;

public partial class OrderDetail
{
    public int OrderDetailsId { get; set; }

    public int OrderId { get; set; }

    public int CategoryId { get; set; }

    public decimal? Size { get; set; }

    public decimal? Weight { get; set; }

    public string HealthStatus { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int Quantity { get; set; }

    public virtual Category Category { get; set; }

    public virtual ICollection<FishHealth> FishHealths { get; set; } = new List<FishHealth>();

    public virtual Order Order { get; set; }
}