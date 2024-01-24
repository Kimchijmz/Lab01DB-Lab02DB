using System;
using System.Collections.Generic;

namespace Lab02DB.Models1;

public partial class Book
{
    public string Isbn13 { get; set; } = null!;

    public string? BookTitle { get; set; }

    public string? BookLanguage { get; set; }

    public int? BookPrice { get; set; }

    public int? BookDate { get; set; }

    public int? PublisherId { get; set; }

    public int? AuthorId { get; set; }

    public virtual Author? Author { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual Publisher? Publisher { get; set; }

    public virtual ICollection<StockBalance> StockBalances { get; set; } = new List<StockBalance>();
}
