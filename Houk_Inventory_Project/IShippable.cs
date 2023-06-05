namespace Houk_Inventory_Project
{
    internal interface IShippable
    {
        decimal ShipCost { get; }
        string Product { get; }
    }
}
