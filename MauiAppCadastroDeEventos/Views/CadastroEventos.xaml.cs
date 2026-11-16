using MauiAppCadastroDeEventos.Models;

namespace MauiAppCadastroDeEventos;

public partial class CadastroEventos : ContentPage
{
	public CadastroEventos()
	{
		InitializeComponent();

		dtpck_inicio.MinimumDate = DateTime.Now;
		dtpck_termino.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        dtpck_termino.MinimumDate = dtpck_inicio.Date.AddDays(1);
        dtpck_termino.MaximumDate = dtpck_inicio.Date.AddMonths(6);
    }

	private async void Button_Clicked(object sender, EventArgs e) 
	{
		try
		{
			Evento ev = new Evento
			{
				NomeEvento = ent_nome.Text,
				DataIni = dtpck_inicio.Date,
				DataTerm = dtpck_termino.Date,
				QntPartic = Convert.ToInt32(stp_participantes.Value),
				LocalEvento = ent_local.Text,
				CustoPartic = Convert.ToInt32(ent_custo.Text),
			};

			await Navigation.PushAsync(new ResumoEvento()
			{
				BindingContext = ev
			});

		} catch (Exception ex)
		{
			await DisplayAlert("Ops, houve um erro!", ex.Message, "OK");
		}
	}

    private void dtpck_inicio_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionada_checkin = elemento.Date;

        dtpck_termino.MinimumDate = data_selecionada_checkin.AddDays(1);
        dtpck_termino.MaximumDate = data_selecionada_checkin.AddMonths(6);
    }
}