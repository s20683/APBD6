using Project6.Models;

namespace Project6.repositories;

public class PatientRepository : IPatientRepository
{
    private readonly HospitalContext _context;

    public PatientRepository(HospitalContext context)
    {
        _context = context;
    }

    public async Task<Patient> GetPatientByIdAsync(int id)
    {
        return await _context.Patients.FindAsync(id);
    }

    public async Task AddPatientAsync(Patient patient)
    {
        await _context.Patients.AddAsync(patient);
        await _context.SaveChangesAsync();
    }
}