namespace MauiAppHoTel.Views;

public partial class ContratacaoDaHospedagem : ContentPage
{
    App PropiedadesApp;

    public ContratacaoDaHospedagem()
    {
        InitializeComponent();

        PropiedadesApp = (App)Application.Current;

        pck_quarto.ItemsSource = PropiedadesApp.lista_quartos;

        stock_checkin.MinimumDate = DateTime.Today;
        stock_checkin.MaximumDate = DateTime.Today.AddMonths(1);

        stock_checkout.MinimumDate = DateTime.Today.AddDays(1);
        stock_checkout.MaximumDate = DateTime.Today.AddMonths(6);
    }

    private async void Avancar_Clicked(object sender, EventArgs e)
    {
        try
        {
            await Navigation.PushAsync(new HospedagemContratada());
        }
        catch
        {
            await DisplayAlert("Erro", "Ocorreu um erro ao processar a solicitação.", "OK");
        }
    }

    // Método do botão Sobre
    private async void Sobre_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sobre());
    }

    private void stock_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DateTime data_selecionada_checkin = e.NewDate.GetValueOrDefault();
        stock_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
        stock_checkout.MaximumDate = data_selecionada_checkin.AddMonths(6);

        stock_checkout.Date = stock_checkout.MinimumDate;
    }

    private void stock_checkout_DateSelected(object sender, DateChangedEventArgs e)
    {
        // Handle check-out date selection if needed
    }
}