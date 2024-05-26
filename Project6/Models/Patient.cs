using System;
using System.Collections.Generic;

namespace Project6.Models;

public partial class Patient
{
    public int IdPatient { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public DateOnly? Birthdate { get; set; }
}
