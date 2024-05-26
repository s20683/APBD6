using Project6.Models;

namespace Project6.repositories;

public interface IPatientRepository
{
    Task<Patient> GetPatientByIdAsync(int id);
    Task AddPatientAsync(Patient patient);
}