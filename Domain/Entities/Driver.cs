using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Driver : AbstractUser
{
    [StringLength(20)]
    public required string DriverLicense {get;set;} = default!;
    public bool IsDriving {get;set;} = false;

    public ICollection<Trip>? Trips {get;set;}

}
