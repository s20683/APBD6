using System;
using System.Collections.Generic;

namespace Project6.Models;

public partial class PrescriptionMedicament
{
    public int IdMedicament { get; set; }

    public int IdPrescription { get; set; }

    public int? Dose { get; set; }

    public string? Details { get; set; }
}
