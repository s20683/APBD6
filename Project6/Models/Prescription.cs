using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project6.Models;

public partial class Prescription
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdPrescription { get; set; }

    public DateTime? Date { get; set; }

    public DateTime? DueDate { get; set; }

    public int? IdPatient { get; set; }

    public int? IdDoctor { get; set; }
    // public List<PrescriptionMedicament>? PrescriptionMedicament { get; set; }
}
