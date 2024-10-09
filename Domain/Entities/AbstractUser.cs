
using System.ComponentModel.DataAnnotations;
using Domain.Enums;

namespace Domain.Entities;

public class AbstractUser : Base
{
    [StringLength(100)]
    public required string FirstName {get; set;} = default!;
    [StringLength(100)]
    public string LastName {get; set;} = "";
    [StringLength(50)]
    public required string UserName {get;set;} = "";
    [StringLength(150)]
    public required string Email {get; set;} = default!;
    [StringLength(100)]
    public required string Password {get; set;} = default!;
    public required EUserType UserType {get;set;} = default!;
    public bool IsActive {get;set;} = true;
}
