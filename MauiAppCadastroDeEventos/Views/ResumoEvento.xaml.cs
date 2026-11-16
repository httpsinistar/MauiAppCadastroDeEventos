namespace MauiAppCadastroDeEventos;

public partial class ResumoEvento : ContentPage
{
	public ResumoEvento()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            await Navigation.PopAsync();

        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops, houve um erro!", ex.Message, "OK");
        }
    }
}