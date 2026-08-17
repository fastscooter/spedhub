using System;
using System.Collections.Generic;

namespace SpedHub.Domain.Entities;

public partial class Goal
{
    public int Id { get; set; }

    public int StudentId { get; set; }

    public decimal Number { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string? Subject { get; set; }

    public bool? IsAcademic { get; set; }

    public string? Timeframe { get; set; }

    public string? Conditions { get; set; }

    public string? Behavior { get; set; }

    public string? Measurement { get; set; }

    public int? Status { get; set; }

    public virtual Student Student { get; set; } = null!;
}
