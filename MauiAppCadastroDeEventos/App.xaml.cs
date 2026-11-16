
using MauiAppCadastroDeEventos.Models;

namespace MauiAppCadastroDeEventos
{
    public partial class App : Application
    {
        public Evento Evento = new Evento();
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new CadastroEventos());
        }
        protected override Window CreateWindow(IActivationState activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 600;
            window.Height = 500;

            return window;
        }
    }
}
