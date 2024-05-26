namespace Project6.Controllers.DTO;

public class PrescriptionRequest
{
    public PatientRequest Patient { get; set; }
    public List<MedicamentRequest> Medicaments { get; set; }
    public DateTime Date { get; set; }
    public DateTime DueDate { get; set; }
}