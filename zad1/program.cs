class Courier()
{

        public string name;
        public List<Shipment> Shupments = new List<Shipment>();

        public void SendShipment(Shipment shipment)
    {
        Shipments.Add(shipment);

        Console.WriteLine($"Куриерска фирма: {Name}");
        Console.WriteLine($"Подател: {shipment.Sender}");
        Console.WriteLine($"Получател: {shipment.Receiver}");
        Console.WriteLine($"Вид пратка: {shipment.TypeName}");
        Console.WriteLine($"Тегло: {shipment.Weight.ToString("0.##", CultureInfo.InvariantCulture)} кг");
        Console.WriteLine($"Цена за доставка: {FormatPrice(CalculatePrice(shipment))}");
        Console.WriteLine("Пратката е изпратена успешно!");
        Console.WriteLine();
    }

     public virtual decimal CalculatePrice(Shipment shipment)
    {
        return 0m;
    }

  class Shipment()
  {

    public enum ShipmentType
   {
    Documents,
    Standard,
    Fragile,
    Express
   }

    public string Sender { get; }
    public string Receiver { get; }
    public double Weight { get; }
    public ShipmentType Type { get; }public string Sender { get;}

    public string TypeName
    {
        get
        {
            switch (Type)
            {
                case ShipmentType.Documents: return "Документи";
                case ShipmentType.Standard:  return "Стандартна";
                case ShipmentType.Fragile:   return "Чуплива";
                case ShipmentType.Express:   return "Експресна";
                default:                     return "Неизвестна";
            }
        }
    }
  }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"=== Куриерска фирма: {Name} ===");
        Console.WriteLine($"Брой приети пратки: {Shipments.Count}");
    }

    protected void PrintShipments()
    {
        foreach (Shipment s in Shipments)
        {
            Console.WriteLine($"{s.Sender} -> {s.Receiver} | {s.TypeName} | {FormatPrice(CalculatePrice(s))}");
        }
    }
}
