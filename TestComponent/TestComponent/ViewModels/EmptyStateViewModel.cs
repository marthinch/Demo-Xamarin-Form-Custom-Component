using System.Windows.Input;
using Xamarin.Forms;

namespace TestComponent.ViewModels
{
    public class EmptyStateViewModel : BaseViewModel
    {
        public ICommand ImageRetryCommand => new Command(ImageRetry);
        public ICommand RetryCommand => new Command(Retry);

        public EmptyStateViewModel()
        {

        }

        private async void ImageRetry()
        {
            await App.Current.MainPage.DisplayAlert("Image tapped", "Please wait...", "OK");
        }

        private async void Retry()
        {
            await App.Current.MainPage.DisplayAlert("Action", "Please wait...", "OK");
        }
    }
}
