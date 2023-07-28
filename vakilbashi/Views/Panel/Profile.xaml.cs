namespace vakilbashi.Views.Panel;

public partial class Profile : ContentPage
{
	public Profile()
	{
		InitializeComponent();

		NavigationPage.SetHasNavigationBar(this, false);


    }

    private async void vakilbashi_Clicked(System.Object sender, System.EventArgs e)
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

    private async void back_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
