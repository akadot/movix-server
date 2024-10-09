namespace Domain.Entities;

public class Manager : AbstractUser
{
    public bool AdminRole {get; set;} = false;
}
