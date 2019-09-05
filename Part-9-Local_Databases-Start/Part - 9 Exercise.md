### Part 9 - Local Databases

1. Project: tipcalcapp, File: App.xaml.cs - uncomment the line below (line 18)

        //private readonly IFileHelper _fileHelper = DependencyService.Get<IFileHelper>();

2. Project: tipcalcapp, File: App.xaml.cs - uncomment the line below (line 57)

        //services.AddTransient<ITipDatabase>(s => new TipDatabase(_fileHelper));

3. Project: tipcalcapp, File: MainPageMasterViewModel.cs - uncomment the line below (line 17)

        //new MainPageMenuItem { Id = 2, Title = "Tip History", Image = "baseline_list_black_18dp.png", IsEnabled = true },

4. Project: tipcalcapp, File: MainPage.xaml.cs - uncomment the lines below (line 42-45)

        //case 2:
        //    item.TargetType = typeof(TipHistoryPage);
        //    page = (Page)Activator.CreateInstance(item.TargetType);
        //    break;

5. Project: tipcalcapp, File: CalculatorPage.xaml - uncomment the lines below (line 116-120)

        <!--<Button x:Name="btnSaveTipTransaction"
            Text="Save"
            WidthRequest="100"
            FontSize="Medium"
            VerticalOptions="Center"></Button>-->

6. Project: tipcalcapp, File: CalculatorPage.xaml.cs - uncomment the line below (line 37)

        //btnSaveTipTransaction.Clicked += OnBtnSaveTipTransactionClicked;