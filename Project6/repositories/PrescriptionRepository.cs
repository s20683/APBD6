using Project6.Models;

namespace Project6.repositories;

public class PrescriptionRepository : IPrescriptionRepository
{
    private readonly HospitalContext _context;

    public PrescriptionRepository(HospitalContext context)
    {
        _context = context;
    }

    public async Task AddPrescriptionAsync(Prescription prescription)
    {
        await _context.Prescriptions.AddAsync(prescription);
        await _context.SaveChangesAsync();
    }
}