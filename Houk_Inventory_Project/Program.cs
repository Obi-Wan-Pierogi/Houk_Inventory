// Lee Houk
// IT112 
// NOTES: This one was fun and took some thinking to get it all to work together.
// BEHAVIORS NOT IMPLEMENTED AND WHY: I think I got them all

namespace Houk_Inventory_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a menu driven choice for the user within a loop that will continue to run until the user chooses to exit or the item count reaches 10
            bool keepGoing = true;
            string userChoice = "";
            Shipper shipper = new Shipper();
            while (keepGoing && shipper.itemCount < 10)
            {
                //display the menu to the user
                Console.WriteLine("Choose from the following options:");
                Console.WriteLine("1. Add a Bicycle to the shipment");
                Console.WriteLine("2. Add a Lawn Mower to the shipment");
                Console.WriteLine("3. Add a Baseball Glove to the shipment");
                Console.WriteLine("4. Add Crackers to the shipment");
                Console.WriteLine("5. List Shipment Items");
                Console.WriteLine("6. Compute Shipping Charges");
                Console.WriteLine("7. Exit");
                //get the user's choice
                userChoice = Console.ReadLine();
                //use a switch statement to determine which item the user chose
                switch (userChoice)
                {
                    case "1":
                        //create a new Bicycle and add it to the cart
                        shipper.Add(new Bicycle());
                        Console.WriteLine("1 Bicycle has been added");
                        Console.WriteLine("Total items in order: " + shipper.itemCount);
                        Refresh();
                        break;
                    case "2":
                        //create a new LawnMower object and add it to the cart
                        shipper.Add(new LawnMower());
                        Console.WriteLine("1 Lawn Mower has been added");
                        Console.WriteLine("Total items in order: " + shipper.itemCount);
                        Refresh();
                        break;
                    case "3":
                        //create a new BaseballGlove object and add it to the cart
                        shipper.Add(new BaseballGlove());
                        Console.WriteLine("1 Baseball Glove has been added");
                        Console.WriteLine("Total items in order: " + shipper.itemCount);
                        Refresh();
                        break;
                    case "4":
                        //create a new Crackers object and add it to the cart
                        shipper.Add(new Crackers());
                        Console.WriteLine("1 Crackers has been added");
                        Console.WriteLine("Total items in order: " + shipper.itemCount);
                        Refresh();
                        break;
                    case "5":
                        //display the items in the cart
                        Console.WriteLine("Shipment manifest:");
                        Console.WriteLine(shipper.ListShipmentItems());
                        Console.WriteLine("Total items in order: " + shipper.itemCount);
                        Refresh();
                        break;
                    case "6":
                        //display the shipping charges and exit the program
                        Console.WriteLine(shipper.ComputeShippingCharges());
                        Console.WriteLine("Press any key to exit the program");
                        Console.ReadKey();
                        //terminate the program
                        keepGoing = false;
                        break;
                    case "7":
                        //set the keepGoing variable to false to exit the loop
                        keepGoing = false;
                        break;
                    default:
                        //display a message if the user enters something other than a valid menu choice
                        Console.WriteLine("Please make a selection from the menu choices");
                        Refresh();
                        break;
                }
            }
            while (keepGoing && shipper.itemCount == 10)
            {
                //Display a shortened menu to the user and inform them that they have reached the maximum number of items
                Console.WriteLine("You have reached the maximum number of items.");
                Console.WriteLine("Choose from the following options:");
                Console.WriteLine("1. List Shipment Items");
                Console.WriteLine("2. Compute Shipping Charges");
                Console.WriteLine("3. Exit");
                userChoice = Console.ReadLine();
                //use a switch statement to determine which item the user chose
                switch (userChoice)
                {
                    case "1":
                        //display the items in the cart
                        Console.WriteLine("Shipment manifest:");
                        Console.WriteLine(shipper.ListShipmentItems());
                        Refresh();
                        break;
                    case "2":
                        //display the shipping charges and exit the program
                        Console.WriteLine(shipper.ComputeShippingCharges());
                        Console.WriteLine("Press any key to exit the program");
                        Console.ReadKey();
                        //terminate the program
                        keepGoing = false;
                        break;
                    case "3":
                        //set the keepGoing variable to false to exit the loop
                        keepGoing = false;
                        break;
                    default:
                        //display a message if the user enters something other than a valid menu choice
                        Console.WriteLine("Invalid choice. Please try again.");
                        Refresh();
                        break;
                }
            }

            // D.R.Y.
            static void Refresh()
            {
                Console.WriteLine("Press any key to return to the menu");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}