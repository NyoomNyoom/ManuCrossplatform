namespace Manu;

using Microsoft.Maui.Controls;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
        InitializeComponent();
	}

    private async Task onBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}