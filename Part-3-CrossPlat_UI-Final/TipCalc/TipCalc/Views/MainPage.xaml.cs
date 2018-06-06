using Xamarin.Forms;
using TipCalc.ViewModels;

namespace TipCalc
{
    public partial class MainPage : ContentPage
    {
        public MainPageViewModel VM { get; }

        public MainPage()
        {
            InitializeComponent();

            this.Padding = (Device.RuntimePlatform == Device.iOS) ? new Thickness(0, 20, 0, 0) : new Thickness(0, 0, 0, 0);

            VM = new MainPageViewModel();
            BindingContext = VM;
        }
    }
}
