using Project6.Models;

namespace Project6.repositories;

public class MedicamentRepository : IMedicamentRepository
{
    private readonly HospitalContext _context;

    public MedicamentRepository(HospitalContext context)
    {
        _context = context;
    }

    public async Task<Medicament> GetMedicamentByIdAsync(int id)
    {
        return await _context.Medicaments.FindAsync(id);
    }
}
