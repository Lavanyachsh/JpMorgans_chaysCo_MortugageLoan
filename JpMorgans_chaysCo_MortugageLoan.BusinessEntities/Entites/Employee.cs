using System;
using System.Collections.Generic;

namespace JpMorgans_chaysCo_MortugageLoan.BusinessEntities;

public partial class Employee
{
    public int Empid { get; set; }

    public string? Empname { get; set; }

    public decimal? Empsalary { get; set; }
}
