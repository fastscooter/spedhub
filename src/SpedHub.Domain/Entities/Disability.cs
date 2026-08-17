using System;
using System.Collections.Generic;

namespace SpedHub.Domain.Entities;

public partial class Disability
{
    public int Id { get; set; }

    public int StudentId { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<Area> Areas { get; set; } = new List<Area>();

    public virtual Student Student { get; set; } = null!;
}
