﻿using System;
using System.Collections.Generic;

namespace Lab02DB.Models1;

public partial class Order
{
    public int OrderId { get; set; }

    public int? CustomerId { get; set; }

    public decimal? PaymentAmount { get; set; }

    public string? PaymentMethod { get; set; }

    public string? Isbn13 { get; set; }

    public virtual Book? Isbn13Navigation { get; set; }
}
