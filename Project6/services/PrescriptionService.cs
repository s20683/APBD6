using Project6.Controllers.DTO;
using Project6.Models;
using Project6.repositories;

namespace Project6.services;

public class PrescriptionService : IPrescriptionService
{
    private readonly IPatientRepository _patientRepository;
    private readonly IMedicamentRepository _medicamentRepository;
    private readonly IPrescriptionRepository _prescriptionRepository;

    public PrescriptionService(IPatientRepository patientRepository, IMedicamentRepository medicamentRepository, IPrescriptionRepository prescriptionRepository)
    {
        _patientRepository = patientRepository;
        _medicamentRepository = medicamentRepository;
        _prescriptionRepository = prescriptionRepository;
    }

    public async Task AddPrescriptionAsync(PrescriptionRequest request)
    {
        var patient = await _patientRepository.GetPatientByIdAsync(request.Patient.IdPatient);
        if (patient == null)
        {
            patient = new Patient
            {
                FirstName = request.Patient.FirstName,
                LastName = request.Patient.LastName
            };
            await _patientRepository.AddPatientAsync(patient);
        }

        if (request.Medicaments.Count > 10)
        {
            throw new InvalidOperationException("Prescription can include up to 10 medicaments.");
        }

        foreach (var med in request.Medicaments)
        {
            var medicament = await _medicamentRepository.GetMedicamentByIdAsync(med.IdMedicament);
            if (medicament == null)
            {
                throw new InvalidOperationException($"Medicament with ID {med.IdMedicament} does not exist.");
            }
        }

        if (request.DueDate < request.Date)
        {
            throw new InvalidOperationException("DueDate must be greater than or equal to Date.");
        }

        var prescription = new Prescription
        {
            IdPatient = patient.IdPatient,
            Date = request.Date,
            DueDate = request.DueDate,
            //todo add doctor
        };
        
        //todo add PrescriptionMEdicaments...

        await _prescriptionRepository.AddPrescriptionAsync(prescription);
    }
}