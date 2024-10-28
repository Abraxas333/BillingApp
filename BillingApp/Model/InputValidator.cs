using System.Collections.Generic;
using System.Windows;

namespace BillingApp.Model
{
    /// <summary>
    /// validating and storing user input 
    /// </summary>
    internal class InputValidator
    {
        // class method that creates and adds a bill to bill collection
        public bool AddBill(List<string> argumentsList, string CompanyName, string CustomerName, string CustomerId, string ItemName, string ItemCount, string pricePerItem)
        {
            // set string values, initialize vars for numeric data
            string companyName = CompanyName;
            string customerName = CustomerName;
            int customerId = 0;
            string itemName = ItemName;
            int itemCount = 0;
            decimal itemPrice = decimal.Zero;

            // check if all input fields are set
            if (argumentsList.TrueForAll(x => !string.IsNullOrEmpty(x))) // check if all fields have input values
            {

                if (!int.TryParse(CustomerId, out customerId)) // check if user input for customerId holds an integer
                {
                    MessageBox.Show("Please input a valid number in the customer ID field."); // prompt user to input an integer if not
                    return false;
                }

                if (!int.TryParse(ItemCount, out itemCount)) // check if user input for item count holds an integer
                {
                    MessageBox.Show("Please input a valid number in the item count field."); // prompt user to input an integer if not
                    return false;
                }

                if (!decimal.TryParse(pricePerItem, out itemPrice)) // check if user input for item price holds a decimal
                {
                    MessageBox.Show("Please input a valid number in the item price field."); // prompt user to input a decimal if not
                    return false;
                }
                else
                {   
                    // create bill 
                    Bill bill = new Bill(companyName, customerName, customerId, itemName, itemCount, itemPrice);
                    return true;
                }

            }
            else
            {
                MessageBox.Show("All fields must contain values."); // prompt user to input values in all fields if any field is empty
                return false;
            }
        }
    }
}
