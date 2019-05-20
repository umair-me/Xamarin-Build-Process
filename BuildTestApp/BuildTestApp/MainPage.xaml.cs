using BuildTestApp.Helpers;
using Xamarin.Forms;

namespace BuildTestApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ServiceName.Text = $"This is '{Secrets.Environment}' environment";
        }
    }
}
