using Microsoft.AspNetCore.Identity;

namespace CustomIdentities.Data;

public class EmployeeCharacteristics : IdentityUser
{
    public EmployeeCharacteristics()
    {
        DateAndTimeReported = DateTime.Now;
    }

    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? PayrollNumber { get; set; }
    public string? Region { get; set; }
    public string? Branch { get; set; }
    public DateTime DateAndTimeReported { get; set; }
}