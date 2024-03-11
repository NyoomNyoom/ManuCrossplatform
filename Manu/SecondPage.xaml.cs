namespace Manu;

using Microsoft.Maui.Controls;

public partial class MainPage : ContentPage
{
	public void SecondPage()
	{
		InitializeComponent();
	}

    private async Task onBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}