namespace Domain.Entities;

public class Vehicle : Base
{
    public string LicensePlate {get; set;} = default!;
    public string Manufacturer {get; set;} = default!;
    public string Model {get; set;} = default!;
    public decimal FuelCapacity {get; set;} = default!;
    public decimal FuelLevel {get; set;} = default!;
    public decimal Kilometer {get; set;} = default!;
    public bool OnDriving {get; set;} = default!;
    public bool OnMaintence {get; set;} = default!;
    public bool IsActive {get; set;} = default!;
}
