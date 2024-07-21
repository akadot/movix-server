namespace Domain.Entities;

public class Trip
{
    public Vehicle Vehicle {get;set;} = default!;
    public Driver Driver {get; set;} = default!;
}
