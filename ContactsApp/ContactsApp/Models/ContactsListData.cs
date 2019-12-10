using System;
using System.Collections.Generic;
using System.Text;

namespace ContactsApp.Models
{
    public class ContactsListData
    {
        public List<Contact> contacts;

        public ContactsListData()
        {
            contacts = new List<Contact>()
            {
                new Contact{ PhoneNumber = "+45 20202020", Name = "Anna"},
                new Contact{ PhoneNumber = "+45 20342020", Name = "Anton"},
                new Contact{ PhoneNumber = "+45 20452020", Name = "Elena"},
                new Contact{ PhoneNumber = "+45 67206720", Name = "Peter"},
                new Contact{ PhoneNumber = "+45 20456720", Name = "John"}
            };
        }
    }
}
