
using Domain.Enums;

namespace Domain.Entities;

public class AbstractUser : Base
{
    public string FirstName {get; set;} = default!;
    public string LastName {get; set;} = "";
    public string Email {get; set;} = default!;
    public string Password {get; set;} = default!;
    public EUserType UserType {get;set;} = default!;
    public bool IsActive {get;set;} = true;
}
