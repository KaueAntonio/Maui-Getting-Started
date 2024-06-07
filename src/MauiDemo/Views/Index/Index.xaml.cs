namespace MauiDemo.Views;

public partial class Index : ContentPage
{
	public Index()
	{
		InitializeComponent();
	}

	private async void OnSignin(object sender, EventArgs e)
	{
		await DisplayAlert("Teste", $"User: {txtUser.Text}\nPassword: {txtPassword.Text}", "Fechar");

		await Navigation.PushAsync(new HomePage());
	}
}
