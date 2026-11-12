using FanRecord.Views;

namespace FanRecord;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        lblIcono.Scale = 0;
        lblIcono.Rotation = -45;
        btnEntrar.Opacity = 0;

        // En .NET 10, se usa "Async" al final
        await Task.WhenAll(
            lblIcono.ScaleToAsync(1, 600, Easing.SpringOut),
            lblIcono.RotateToAsync(0, 600, Easing.SpringOut),
            btnEntrar.FadeToAsync(1, 800)
        );
    }

    private async void OnEntrarClicked(object sender, EventArgs e)
    {
        // Navegar a la galería (la crearemos en el siguiente paso)
        await Navigation.PushAsync(new GaleriaPage());
    }
}