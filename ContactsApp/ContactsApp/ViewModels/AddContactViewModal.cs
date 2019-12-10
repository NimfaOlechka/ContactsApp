using ContactsApp.Models;
using ContactsApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using System.ComponentModel;
using System.Threading.Tasks;

namespace ContactsApp.ViewModels
{
    class AddContactViewModal :INotifyPropertyChanged
    {
        public Command SaveCommand { get; set; }
        public Command CancelCommand { get; set; }

        public Contact Contact { get; set; }
        
        public AddContactViewModal()
        {
            Contact = new Contact
            {
                PhoneNumber = "Phoone number",
                Name = "Coontact Name"
            };
           
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
