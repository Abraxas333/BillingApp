using BillingApp.Model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using MessageBox = Xceed.Wpf.Toolkit.MessageBox;

namespace BillingApp.View
{
    /// <summary>
    /// Interaction logic for WindowApp.xaml
    /// </summary>
    public partial class WindowApp : Window
    {
        public WindowApp()
        {
            InitializeComponent();
        }

        private void saveToFile(object sender, RoutedEventArgs e)
        {
            // initializing a new List, adding input field values to list
            List<string> argumentsList = new List<string> 
            {
                CompanyNameValue.Text,
                CustomerNameValue.Text,
                CustomerId.Text,
                ItemNameValue.Text,
                ItemCountValue.Text,
                PricePerItemValue.Text
            };

            // initializing variables that will hold field values
            string companyName = CompanyNameValue.Text;
            string customerName = CustomerNameValue.Text;
            string customerId = CustomerId.Text;
            string itemName = ItemNameValue.Text;
            string itemCount = ItemCountValue.Text;
            string itemPrice = PricePerItemValue.Text;

            // create an instance of InputValidator class 
            InputValidator validator = new InputValidator();

            // define a boolean that returns true if bill is added
            bool input = validator.AddBill(argumentsList, companyName, customerName, customerId, itemName, itemCount, itemPrice);

            // if bill is added successfully show the collection of bills in a popup
            if (input)
            {
                string s = String.Join(".\n", Bill.billCollection);
                MessageBox.Show($"Saved Bills: {s}");

                // clear input fields 
                CompanyNameValue.Text = String.Empty;
                CustomerNameValue.Text = String.Empty;
                CustomerId.Text = String.Empty;
                ItemNameValue.Text = String.Empty;
                ItemCountValue.Text = String.Empty;
                PricePerItemValue.Text = String.Empty;
            }
        }

        // event handler for export to text file on button click
        private void openSaveFileDialog(object sender, RoutedEventArgs e)
        {
            // initialize a string builder named bills
            StringBuilder bills = new StringBuilder();

            // appending return vatlue of bill.ToString() method to string bills separated by a new line character
            Bill.billCollection.ForEach(bill => { bills.Append(bill.ToString() + "\n"); });

            // create an instance of SaveFileDialog class
            SaveFileDialog sfd = new SaveFileDialog();

            // initialize a bool success that will evaluate to true if SaveFileDialog is initialized successfull
            bool? success = sfd.ShowDialog(); 
         
            try
            {
                if (success == true)

                {
                    // if bool success evaluates to true: call the File.WriteAllText method of SaveFileDialog
                    File.WriteAllText(sfd.FileName, bills.ToString());

                    // show popup with the filepath of saved bills text file
                    MessageBox.Show($"Bills saved successfully in: {sfd.FileName}");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured: {ex.Message}"); // show error message if exception occurrs 
            }
        }
    }
}
