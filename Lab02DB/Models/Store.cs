﻿using System;
using System.Collections.Generic;

namespace Lab02DB.Models1;

public partial class Store
{
    public int StoreId { get; set; }

    public string? StoreName { get; set; }

    public string? Adress { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual ICollection<StockBalance> StockBalances { get; set; } = new List<StockBalance>();
}
