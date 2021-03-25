using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.Messaging;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonSend_Clicked(object sender, EventArgs e)
        {
            var emailMessenger = CrossMessaging.Current.EmailMessenger;
            if (emailMessenger.CanSendEmail)
            {
                emailMessenger.SendEmail($"{picker.SelectedItem}", $"{EntrySubject}");
            }
            ButtonSend.Text = "Отправлено!";
        }

        private void randombutton_Clicked(object sender, EventArgs e)
        {
            if (picker.SelectedIndex == 0)
            {
                EntrySubject.Text = $"{picker}";
            }
            if (picker.SelectedIndex == 1)
            {
                EntrySubject.Text = $"{picker}";
            }
            if (picker.SelectedIndex == 2)
            {
                EntrySubject.Text = $"{picker}";
            }
            if (picker.SelectedIndex == 3)
            {
                EntrySubject.Text = $"{picker}";
            }
            if (picker.SelectedIndex == 4)
            {
                EntrySubject.Text = $"{picker}";
            }
        }
    }
}
