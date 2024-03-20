namespace Manu;

using Microsoft.Maui.Controls;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
        InitializeComponent();
	}

    private async Task GoingBack(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void OnBack_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NavigationPage(new MainPage()));
    }
}