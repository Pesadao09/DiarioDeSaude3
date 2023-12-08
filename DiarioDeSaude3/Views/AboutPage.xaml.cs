namespace DiarioDeSaude3.Views;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}

    private async void btnSobre_Clicked(object sender, EventArgs e)
    {
		await Launcher.Default.OpenAsync("https://www.facebook.com/kyohei.matsuno.376?locale=pt_BR");

		if (BindingContext is Models.About about)

		await Launcher.Default.OpenAsync(about.MoreInfoUrl);
    }
}