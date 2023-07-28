namespace vakilbashi;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
		NavigationPage.SetHasNavigationBar(this, false);

    }

    private async void Logo_Clicked(System.Object sender, System.EventArgs e)
    {
        try
        {
            Uri uri = new Uri("https://www.vakilbashi.org");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex)
        {
            // An unexpected error occurred. No browser may be installed on the device.
            Console.WriteLine(ex);
        }
    }

    private async void Light_System(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
        //await Navigation.PushAsync(new Views.Products.Light());
        await Navigation.PushAsync(new Views.Panel.ProfileDetail());
    }
}


