using System;
using System.Collections.Generic;

namespace SpedHub.Domain.Entities;

public partial class Area
{
    public int Id { get; set; }

    public int DisabilityId { get; set; }

    public string Description { get; set; } = null!;

    public virtual Disability Disability { get; set; } = null!;
}
