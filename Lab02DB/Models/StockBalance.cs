using System;
using System.Collections.Generic;

namespace Lab02DB.Models1;

public partial class StockBalance
{
    public string Isbn13 { get; set; } = null!;

    public int StoreId { get; set; }

    public int? Quantity { get; set; }

    public virtual Book Isbn13Navigation { get; set; } = null!;

    public virtual Store Store { get; set; } = null!;
    public virtual Book Book { get; internal set; }
}
