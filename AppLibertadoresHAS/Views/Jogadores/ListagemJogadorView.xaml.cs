using AppLibertadoresHAS.ViewModels;

namespace AppLibertadoresHAS.Views.Jogadores;

public partial class ListagemJogadorView : ContentPage
{
    ListagemJogadorViewModel jogadorViewModel;
    public ListagemJogadorView()
    {
        InitializeComponent();

        jogadorViewModel = new ListagemJogadorViewModel();
        BindingContext = jogadorViewModel;
        Title = "Jogadores";
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        _ = jogadorViewModel.ObterJogadores();
    }
}