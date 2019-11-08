using Prism;
using Prism.Ioc;
using LitterBugApp.ViewModels;
using LitterBugApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LitterBugApp.Views.Main;
using LitterBugApp.ViewModels.Main;
using LitterBugApp.Views.Navigation;
using LitterBugApp.ViewModels.Navigation;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace LitterBugApp
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("TabNavPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<PositivePage, PositivePageViewModel>();
            containerRegistry.RegisterForNavigation<NegativePage, NegativePageViewModel>();
            containerRegistry.RegisterForNavigation<TabNavPage, TabNavPageViewModel>();
        }
    }
}
