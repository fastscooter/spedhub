using System;
using System.Collections.Generic;

namespace SpedHub.Domain.Entities;

public partial class Accommodation
{
    public int Id { get; set; }

    public int StudentId { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string? Category { get; set; }

    public string Description { get; set; } = null!;

    public bool Elar { get; set; }

    public bool Math { get; set; }

    public bool Science { get; set; }

    public bool SocialStudies { get; set; }

    public virtual Student Student { get; set; } = null!;
}
