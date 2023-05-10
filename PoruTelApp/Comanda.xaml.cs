using CommunityToolkit.Mvvm.ComponentModel;
using Dto;
using PoruTelApp.ViewModels;
using System.ComponentModel;

namespace PoruTelApp;

public partial class Comanda : ContentPage
{
    private ComandaViewModel viewModel;

    public Comanda(ComandaViewModel comandaViewModel)
    {
        InitializeComponent();
        BindingContext = comandaViewModel;
        viewModel = comandaViewModel;
    }

    private void Kurtosplus_Clicked(object sender, EventArgs e)
    {
        viewModel.ContorKurtos++;
    }

    private void Kurtosminus_Clicked(object sender, EventArgs e)
    {
        viewModel.ContorKurtos--;
    }

    private void Limoplus_Clicked(object sender, EventArgs e)
    {
        viewModel.ContorLimonada++;
    }

    private void LimoMINUS_Clicked(object sender, EventArgs e)
    {
        viewModel.ContorLimonada--;
    }

    private void Inghetataplus_Clicked(object sender, EventArgs e)
    {
        viewModel.ContorInghetata++;
    }

    private void InghetataMinus_Clicked(object sender, EventArgs e)
    {
        viewModel.ContorInghetata--;
    }

    private void ResetCounter_Clicked(object sender, EventArgs e)
    {
        viewModel.ContorInghetata = 0;
        viewModel.ContorKurtos = 0;
        viewModel.ContorLimonada = 0;
        viewModel.ContorKurtosInghetata = 0;
    }

    private void KurtosInghetataplus_Clicked(object sender, EventArgs e)
    {
        viewModel.ContorKurtosInghetata++;
    }

    private void KurtosInghetataMinus_Clicked(object sender, EventArgs e)
    {
        viewModel.ContorKurtosInghetata--;
    }
}