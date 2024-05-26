using Project6.Models;

namespace Project6.repositories;

public interface IPrescriptionRepository
{
    Task AddPrescriptionAsync(Prescription prescription);
}