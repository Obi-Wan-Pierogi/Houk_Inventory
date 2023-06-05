namespace Houk_Inventory_Project
{
    internal class Bicycle : IShippable
    {        
        public decimal ShipCost { get; } = 9.50M;
        public string Product { get; } = "Bicycle";
    }
}
