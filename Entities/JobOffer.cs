using System;
using System.Collections.Generic;

namespace _21100744PARCIALWEB.Entities;

public partial class JobOffer
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public double? Salary { get; set; }

    public string? Location { get; set; }
}
