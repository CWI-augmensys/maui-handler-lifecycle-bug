//using Intents;

namespace MauiLifeCycleTest2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        public static NavigationPage NavigationPage { get; private set; }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            NavigationPage = new NavigationPage(new MainPage());
            return new Window(NavigationPage);
        }
    }
}