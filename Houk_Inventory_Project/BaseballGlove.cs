namespace Houk_Inventory_Project
{
    internal class BaseballGlove : IShippable
    {
        public decimal ShipCost { get; } = 3.23M;
        public string Product { get; } = "Baseball Glove";
    }
}
