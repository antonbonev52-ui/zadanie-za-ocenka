public class Econt : Courier
{
    public Econt() : base("Econt") { }

    public override decimal CalculatePrice(Shipment shipment)
    {
        decimal price = 0;

        if (shipment.Type == ShipmentType.Documents) price = 3.50m;
        else if (shipment.Type == ShipmentType.Standard) price = 6.50m;
        else if (shipment.Type == ShipmentType.Fragile) price = 8;
        else if (shipment.Type == ShipmentType.Express) price = 11;

        if (shipment.Weight > 3)
        {
            price += (decimal)Math.Ceiling(shipment.Weight - 3) * 2;
        }

        return price;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine("Над 3 кг: +2 лв. за всеки кг");
        PrintShipments();
    }
}