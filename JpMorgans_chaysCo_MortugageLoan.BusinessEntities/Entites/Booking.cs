using System;
using System.Collections.Generic;

namespace JpMorgans_chaysCo_MortugageLoan.BusinessEntities;


public partial class Booking
{
    public int? Id { get; set; }

    public string? CustomerName { get; set; }

    public string? Location { get; set; }

    public DateOnly? Date { get; set; }
}
