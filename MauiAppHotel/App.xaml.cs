namespace MauiAppHoTel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = new Window(
                new NavigationPage(new Views.ContratacaoDaHospedagem()));

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}