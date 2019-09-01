using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using TipCalc.ViewModels;

namespace TipCalc
{
    public partial class MainPage : ContentPage
    {
        public MainPageViewModel VM { get; }

        public MainPage()
        {
            InitializeComponent();
            On<iOS>().SetUseSafeArea(true);

            //this.Padding = (Device.RuntimePlatform == Device.iOS) ? new Thickness(0, 20, 0, 0) : new Thickness(0, 0, 0, 0);

            VM = new MainPageViewModel();
            BindingContext = VM;
        }
    }
}
