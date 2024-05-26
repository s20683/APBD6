using Project6.Controllers.DTO;

namespace Project6.services;

public interface IPrescriptionService
{
    Task AddPrescriptionAsync(PrescriptionRequest request);
}