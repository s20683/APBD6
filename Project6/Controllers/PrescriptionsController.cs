using Microsoft.AspNetCore.Mvc;
using Project6.Controllers.DTO;
using Project6.services;

namespace Project6.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PrescriptionsController : ControllerBase
{
    private readonly IPrescriptionService _prescriptionService;

    public PrescriptionsController(IPrescriptionService prescriptionService)
    {
        _prescriptionService = prescriptionService;
    }

    [HttpPost]
    public async Task<IActionResult> CreatePrescription([FromBody] PrescriptionRequest request)
    {
        try
        {
            await _prescriptionService.AddPrescriptionAsync(request);
            return Ok("Prescription created successfully.");
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(ex.Message);
        }
    }
}