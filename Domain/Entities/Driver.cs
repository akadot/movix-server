namespace Domain.Entities;

public class Driver : AbstractUser
{
    public string DriverLicense {get;set;} = default!;
    public bool IsDriving {get;set;} = false;
}
