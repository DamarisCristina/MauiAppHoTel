namespace MauiAppHoTel.Views;

public partial class ContratacaoDaHospedagem : ContentPage
{
    public ContratacaoDaHospedagem()
    {
        InitializeComponent();
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

    private async void Sobre_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sobre());
    }
}