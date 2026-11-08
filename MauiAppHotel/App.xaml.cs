using MauiAppHoTel.Models;

namespace MauiAppHoTel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()

            {
                Descricao = "Suite Super Luxo",
                ValorDiarioAdulto = 110.0,
                ValorDiarioCrianca = 55.0
            },
            new Quarto()

            {
                Descricao = "Suite  Luxo",
                ValorDiarioAdulto = 80.0,
                ValorDiarioCrianca = 40.0
            },
            new Quarto()

            {
                Descricao = "Suite  Single",
                ValorDiarioAdulto = 50.0,
                ValorDiarioCrianca = 25.0
            },
            new Quarto()

            {
                Descricao = "Suite  Crise",
                ValorDiarioAdulto = 25.0,
                ValorDiarioCrianca = 12.5
            }
        };

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