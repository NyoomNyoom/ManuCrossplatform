namespace Manu;

using Microsoft.Maui.Controls;

public partial class MainPage : ContentPage
{
    // Constructor
    public MainPage()
    {
        InitializeComponent();
    }

    // Event handler for Play button click
    private async void OnPlayClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }

    // Event handler for Encyclopedia button click
    private async void OnEncyclopediaClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NavigationPage(new MainPage()));
    }
}


