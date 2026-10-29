namespace MauiAppHoTel.Views;

public partial class ContratacaoDaHospedagem : ContentPage
{
    public ContratacaoDaHospedagem()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("SobrePage");
    }
}