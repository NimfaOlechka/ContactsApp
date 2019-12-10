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
    class ContactsViewModel: INotifyPropertyChanged
    {
        //collection to store all contacts
        public ObservableCollection<Contact> Contacts { get; set; }
        //command to load collection
        public Command AddContactCommand { get; set; }
        //command to add new contact
        public ContactsViewModel()
        {
           //create some data
            Contacts = new ObservableCollection<Contact>()
            {
                new Contact{ PhoneNumber = "+45 20202020", Name = "Anna"},
                new Contact{ PhoneNumber = "+45 20342020", Name = "Anton"},
                new Contact{ PhoneNumber = "+45 20452020", Name = "Elena"},
                new Contact{ PhoneNumber = "+45 67206720", Name = "Peter"},
                new Contact{ PhoneNumber = "+45 20456720", Name = "John"}
            };

            AddContactCommand = new Command(async()=> {
                var addContacPage = new AddNewContactPage();
                await Application.Current.MainPage.Navigation.PushAsync(addContacPage);
            });
        }
        

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
