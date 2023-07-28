namespace vakilbashi.Views.Panel;

public partial class ProfileDetail : ContentPage
{
	public ProfileDetail()
	{
		InitializeComponent();

		NavigationPage.SetHasNavigationBar(this, false);
	}

    private async void back_Clicked(System.Object sender, System.EventArgs e)
    {
		await Navigation.PopAsync();
    }

    void TapGestureRecognizer_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
    }
}