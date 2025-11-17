using MauiEventos.Models;

namespace MauiEventos.Views;

public partial class CadastroEventoPage : ContentPage
{
    Evento evento;

    public CadastroEventoPage()
    {
        InitializeComponent();
        evento = new Evento()
        {
            DataInicio = DateTime.Today,
            DataFim = DateTime.Today
        };

        BindingContext = evento;
    }

    private async void OnCadastrarClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ResumoEventoPage(evento));
    }
}
