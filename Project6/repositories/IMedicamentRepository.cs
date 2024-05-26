using Project6.Models;

namespace Project6.repositories;

public interface IMedicamentRepository
{
    Task<Medicament> GetMedicamentByIdAsync(int id);
}