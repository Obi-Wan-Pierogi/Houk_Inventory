namespace Houk_Inventory_Project
{    
    internal class Shipper
    {
        private List<IShippable> _shippables = new List<IShippable>();
        private int _bicycleCount = 0;
        private int _lawnMowerCount = 0;
        private int _baseballGloveCount = 0;
        private int _crackerCount = 0;
        private int _itemCount = 0;
        private decimal _totalCost = 0.00M;
        
        //Void function that accepts an object of type IShippable and adds it to the list
        public void Add(IShippable item)
        {
            _shippables.Add(item);
            _itemCount++;
            if(item.Product == "Bicycle")
            {
                _bicycleCount++;
            }
            else if (item.Product == "Lawn Mower")
            {
                _lawnMowerCount++;
            }
            else if (item.Product == "Baseball Glove")
            {
                _baseballGloveCount++;
            }
            else if (item.Product == "Crackers")
            {
                _crackerCount++;
            }
        }

        //List Shipment Items with correct singular or plural form.
        public string ListShipmentItems()
        {
            string bicycle = " ";
            string lawnMower = " ";
            string baseballGlove = " ";
            string crackers = " ";

            if (_itemCount == 0)
            {
                return "No items have been added.";                
            }
            else
            {                
                if (_bicycleCount > 0)
                {
                    if (_bicycleCount == 1)
                    {
                        bicycle = "1 Bicycle\n";
                    }
                    else
                    {
                        bicycle = $"{_bicycleCount} Bicycles\n";
                    }
                }
                if (_lawnMowerCount > 0)
                {
                    if (_lawnMowerCount == 1)
                    {
                         lawnMower = "1 Lawn Mower\n";
                    }
                    else
                    {
                        lawnMower = $"{_lawnMowerCount} Lawn Mowers\n";
                    }
                }
                if (_baseballGloveCount > 0)
                {
                    if (_baseballGloveCount == 1)
                    {
                        baseballGlove = "1 Baseball Glove\n";
                    }
                    else
                    {
                        baseballGlove = $"{_baseballGloveCount} Baseball Gloves\n";
                    }
                }
                if (_crackerCount > 0)
                {
                    crackers = $"{_crackerCount} Crackers";
                }                              
            }
            // send back a string with correct singular or plural form and leaves out items with 0
            return bicycle + lawnMower + baseballGlove + crackers;
        }

        //Compute Shipping Charges
        public string ComputeShippingCharges()
        {
            if (_itemCount == 0)
            {
                return "No items have been added.";
            }
            else
            {
                foreach (IShippable item in _shippables)
                {
                    _totalCost += item.ShipCost;
                }
                return "Total shipping cost for this order is " + _totalCost.ToString("C");        
            }
        }

        //Properties
        public int itemCount
        {
            get
            {
                return _itemCount;
            }
        }

        //public int bicycleCount
        //{
        //    get
        //    {
        //        return _bicycleCount;
        //    }
        //}

        //public int lawnMowerCount
        //{
        //    get
        //    {
        //        return _lawnMowerCount;
        //    }
        //}

        //public int baseballGloveCount
        //{
        //    get
        //    {
        //        return _baseballGloveCount;
        //    }
        //}

        //public int crackerCount
        //{
        //    get
        //    {
        //        return _crackerCount;
        //    }
        //}

        public decimal totalCost
        {
            get
            {
                return _totalCost;
            }
        }
    }
}
