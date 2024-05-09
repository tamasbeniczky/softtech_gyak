using System;
using System.Collections.Generic;

namespace LINQ_lekérdezések.Models;

public partial class Employement
{
    public string EmployementId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<Ora> Instructors { get; set; } = new List<Ora>();
}
