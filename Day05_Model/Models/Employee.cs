using System;
using System.Collections.Generic;

namespace Day05_Model.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string FullName { get; set; } = null!;

    public string? Gender { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public decimal? Salary { get; set; }

    public string? Status { get; set; }
}
