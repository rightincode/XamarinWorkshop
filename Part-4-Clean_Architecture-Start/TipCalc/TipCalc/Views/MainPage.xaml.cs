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

            VM = new MainPageViewModel();
            BindingContext = VM;
        }
    }
}
