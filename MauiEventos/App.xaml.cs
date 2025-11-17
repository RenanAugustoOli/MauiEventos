using MauiEventos.Views;

namespace MauiEventos;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new CadastroEventoPage());
    }
}
