﻿using System.Linq;
using tipcalc;
using tipcalcapp.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace tipcalcapp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPageMaster : ContentPage
    {
        public Xamarin.Forms.ListView TipCalcProMenuItems;
        
        public MainPageMaster()
        {
            InitializeComponent();
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
            //bool LoggedIn = (App.AuthenticationProvider.AuthClient.Users.Count() > 0) ? true : false;
            //BindingContext = new MainPageMasterViewModel(LoggedIn);
            BindingContext = new MainPageMasterViewModel(true);
            TipCalcProMenuItems = MenuItemsListView;            
        }        
    }
}