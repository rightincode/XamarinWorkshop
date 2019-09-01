using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace TipCalc
{
	public partial class MainPage : ContentPage
	{
        public TipCalculator tipCalculator;

		public MainPage()
		{
			InitializeComponent();
            On<iOS>().SetUseSafeArea(true);

            tipCalculator = new TipCalculator
            {
                Total = 100,
                TipPercent = 18
            };
            tipCalculator.CalcTip();

            BindingContext = tipCalculator;
        }
	}
}
