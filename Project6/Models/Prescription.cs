using System;
using System.Collections.Generic;

namespace Project6.Models;

public partial class Prescription
{
    public int IdPrescription { get; set; }

    public DateOnly? Date { get; set; }

    public DateOnly? DueDate { get; set; }

    public int? IdPatient { get; set; }

    public int? IdDoctor { get; set; }
}
