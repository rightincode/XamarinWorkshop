using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using TipCalc.ViewModels;
using TipCalc_core.Models;

namespace TipCalc
{
    public partial class MainPage : ContentPage
    {
        public MainPageViewModel VM { get; }

        public MainPage()
        {
            InitializeComponent();
            On<iOS>().SetUseSafeArea(true);

            VM = new MainPageViewModel(new TipCalculator());
            BindingContext = VM;
        }
    }
}
