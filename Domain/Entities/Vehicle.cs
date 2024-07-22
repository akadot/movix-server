namespace Domain.Entities;

public class Vehicle : Base
{
    public string LicensePlate {get; set;} = default!;
    public string Manufacturer {get; set;} = default!;
    public string Model {get; set;} = default!;
    public decimal FuelCapacity {get; set;} = default!;
    public decimal FuelPerKilometer {get; set;} = default!;
    public decimal FuelLevel {get; private set;} = default!;
    public decimal Kilometer {get; private set;} = default!;
    public bool OnDriving {get; private set;} = default!;
    public bool OnMaintence {get; set;} = default!;
    public bool IsActive {get; set;} = default!;

    //só pode iniciar a viagem se o tanque estiver cheio (ou se o nivel for compativel com a distância)
    //só pode encher o tanque se o carro não estiver em viagem
    public void CheckDriveCanStart(){
        this.OnDriving = this.FuelLevel == this.FuelCapacity;
    }

    public void CanFillFuel(){
        
    }
}
