using System;
using System.Collections.Generic;

namespace BillingApp.Model
{

    public class Bill
    {
        
        // private fields
        private string _company;

        private string _customer;

        private int _customerId;

        private string _itemName;

        private int _quantity;

        private decimal _pricePerItem;


        // getter & setter
        public string Company
        {
            get => _company;
            set => _company = value;
        }

        public string Customer
        {
            get => _customer;
            set => _customer = value;
        }

        public int CustomerId
        {
            get => _customerId;
            set => _customerId = value;
        }
      
        public string ItemName
        {
            get => _itemName;
            set => _itemName = value;
        }
       
        public int Quantity
        {
            get => _quantity;
            set => _quantity = value;
        }
       
        public decimal PricePerItem
        {
            get => _pricePerItem;
            set => _pricePerItem = value;
        }

        // instance list
        public static List<Bill> billCollection = new List<Bill>();

        // constructor
        public Bill(string company, string customer, int customerId, string itemName, int quantity, decimal pricePerItem)
        {  
            Company = company;
            Customer = customer;
            CustomerId = customerId;
            ItemName = itemName;
            Quantity = quantity;
            PricePerItem = pricePerItem;
            billCollection.Add(this);
        }

        // method to return bill as a formatted string 
        public override string ToString()
            {
                return $"Company Name: {Company}, Customer Name: {Customer}, Customer Id: {CustomerId}, Item Id: {ItemName}, Quantity: {Quantity}, Price per Item: {PricePerItem}, Total (including VAT): {Math.Round((Quantity * PricePerItem) + (((Quantity*PricePerItem)/100)*20),2)}";
            }
    }
}

