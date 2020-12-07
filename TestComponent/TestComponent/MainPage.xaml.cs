using System;
using TestComponent.Pages;
using Xamarin.Forms;

namespace TestComponent
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ButtonEntryComponent_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EntryComponentPage());
        }

        private async void ButtonSwitchComponent_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SwitchComponentPage());
        }

        private async void ButtonEmptyPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EmptyStatePage());
        }
    }
}
