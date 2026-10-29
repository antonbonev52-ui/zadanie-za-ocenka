public class Speedy : Courier
{
    public Speedy() : base("Speedy") { }

    public override decimal CalculatePrice(Shipment shipment)
    {
        decimal price = 0;

        if (shipment.Type == ShipmentType.Documents) price = 4;
        else if (shipment.Type == ShipmentType.Standard) price = 6;
        else if (shipment.Type == ShipmentType.Fragile) price = 9;
        else if (shipment.Type == ShipmentType.Express) price = 12;

        if (shipment.Weight > 2)
        {
            price += (decimal)Math.Ceiling(shipment.Weight - 2) * 1.50m;
        }

        return price;
    }
    public override void PrintInfo()
     {
        base.PrintInfo();
        Console.WriteLine("Над 2 кг: +1.50 лв. за всеки кг");
        PrintShipments();
     }
}