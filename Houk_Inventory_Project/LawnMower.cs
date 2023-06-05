namespace Houk_Inventory_Project
{
    internal class LawnMower : IShippable
    {
        public decimal ShipCost { get; } = 24.00M;
        public string Product { get; } = "Lawn Mower";
    }
}
