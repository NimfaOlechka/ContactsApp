using ContactsApp.Models;
using Plugin.Permissions.Abstractions;
using Plugin.Permissions;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Diagnostics;

namespace ContactsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsListViewPage : ContentPage
    {
        

        public ContactsListViewPage()
        {
            InitializeComponent();
            

        }

        async private void PhoneContactsButton_Clicked(object sender, EventArgs e)
        {
            int commandParameter = Convert.ToInt32(((Button)sender).CommandParameter);

            Permission permission = (Permission)commandParameter;
            var permissionStatus = await CrossPermissions.Current.CheckPermissionStatusAsync(permission);

            if(permissionStatus != PermissionStatus.Granted)
            {
                var response = await CrossPermissions.Current.RequestPermissionsAsync(permission);
                var userResponse = response[permission];

                Debug.WriteLine($"Permission {permission} {userResponse}");
            }
            else
            {
                Debug.WriteLine($"Permission {permission} : {permissionStatus}");
            }
        }
    }
}
