using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Models
{
    public class ContactsListData: IDataStore<Contact>
    {
        readonly List<Contact> contacts;

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

        public async Task<bool> AddItemAsync(Contact item)
        {
            contacts.Add(item);
            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var contactToDelete = contacts.Where((Contact arg) => arg.PhoneNumber == id).FirstorDefault();
            contacts.Remove(contactToDelete);
            return await Task.FromResult(true);
        }

        public async Task<Contact> GetItemAsync(string id)
        {
            return await Task.FromResult(contacts.FirstOrDefault(c => c.PhoneNumber == id || c.Name == id));
        }

        public async Task<IEnumerable<Contact>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(contacts);
        }

        public async Task<bool> UpdateItemAsync(Contact item)
        {
            var oldItem = contacts.Where((Contact arg) => arg.PhoneNumber == item.PhoneNumber).FirstOrDefault();
            contacts.Remove(oldItem);
            contacts.Add(item);
            return await Task.FromResult(true);
        }
    }
}
