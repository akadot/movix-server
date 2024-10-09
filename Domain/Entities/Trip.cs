namespace Domain.Entities;

public class Trip : Base
{
    public required Vehicle Vehicle {get;set;} = default!;
    public required Driver Driver {get; set;} = default!;
}
