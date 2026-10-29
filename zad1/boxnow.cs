public class BoxNow : Courier
{
    public BoxNow() : base("Box Now") { }

    public override decimal CalculatePrice(Shipment shipment)
    {
        decimal price = 0;

        if (shipment.Type == ShipmentType.Documents) price = 3;
        else if (shipment.Type == ShipmentType.Standard) price = 5;
        else if (shipment.Type == ShipmentType.Fragile) price = 7;
        else if (shipment.Type == ShipmentType.Express) price = 10;

        if (shipment.Weight > 2)
        {
            price += (decimal)Math.Ceiling(shipment.Weight - 2) * 1;
        }

        return price;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine("Над 2 кг: +1 лв. за всеки кг");
        PrintShipments();
    }
}