using System;
using System.Collections.Generic;

namespace SpedHub.Domain.Entities;

public partial class Service
{
    public int Id { get; set; }

    public int StudentId { get; set; }

    public int Type { get; set; }

    public int Subject { get; set; }

    public int Minutes { get; set; }

    public string Frequency { get; set; } = null!;

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public virtual Student Student { get; set; } = null!;
}
