using System;
using System.Collections.Generic;

namespace LINQ_lekérdezések.Models;

public partial class Status
{
    public byte StatusId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Ora> Instructors { get; set; } = new List<Ora>();
}
