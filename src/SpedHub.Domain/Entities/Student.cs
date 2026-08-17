using System;
using System.Collections.Generic;

namespace SpedHub.Domain.Entities;

public partial class Student
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateOnly? DateOfBirth { get; set; }

    public string? Gender { get; set; }

    public int GradeLevel { get; set; }

    public virtual ICollection<Accommodation> Accommodations { get; set; } = new List<Accommodation>();

    public virtual ICollection<Disability> Disabilities { get; set; } = new List<Disability>();

    public virtual ICollection<Goal> Goals { get; set; } = new List<Goal>();

    public virtual ICollection<Service> Services { get; set; } = new List<Service>();
}
