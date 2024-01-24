using System;
using System.Collections.Generic;

namespace Lab02DB.Models1;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string? EmployeeFirstName { get; set; }

    public string? EmployeeLastName { get; set; }

    public string? EmployeeEmail { get; set; }

    public int? StoreId { get; set; }

    public virtual Store? Store { get; set; }
}
