using System;
using System.Collections.Generic;

namespace Lab02DB.Models1;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public int? PhoneNumber { get; set; }
}
