namespace Manu;

using Microsoft.Maui.Controls;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnPlayClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new SecondPage());
	}

	private async void OnEncyclopediaClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new SecondPage());
	}
}

