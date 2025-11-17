using MauiEventos.Models;

namespace MauiEventos.Views;

public partial class CadastroEventoPage : ContentPage
{
    public CadastroEventoPage()
    {
        InitializeComponent();
    }

    private async void Cadastrar_Clicked(object sender, EventArgs e)
    {
        var evento = new Evento
        {
            Nome = txtNome.Text,
            DataInicio = dtInicio.Date,
            DataFim = dtFim.Date,
            NumeroParticipantes = int.Parse(txtParticipantes.Text),
            Local = txtLocal.Text,
            CustoPorParticipante = double.Parse(txtCusto.Text)
        };

        await Navigation.PushAsync(new ResumoEventoPage
        {
            BindingContext = evento
        });
    }
}
