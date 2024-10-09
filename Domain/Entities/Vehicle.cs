using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Vehicle : Base
{
    [StringLength(20)]
    public required string LicensePlate {get; set;} = default!;
    [StringLength(100)]
    public string Manufacturer {get; set;} = default!;
    [StringLength(100)]
    public required string Model {get; set;} = default!;
    public decimal FuelCapacity {get; set;} = default!;
    public decimal FuelPerKilometer {get; set;} = default!;
    public decimal FuelLevel {get; private set;} = default!;
    public decimal Kilometer {get; private set;} = default!;
    public bool OnDriving {get; private set;} = default!;
    public bool OnMaintence {get; set;} = default!;
    public bool IsActive {get; set;} = default!;

    public ICollection<Trip>? Trips {get;set;}
}
