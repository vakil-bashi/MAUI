using Microsoft.Maui.Controls;

namespace vakilbashi.Views.Panel;

public partial class ProfileList : ContentPage
{
	public ProfileList()
	{
		InitializeComponent();

		NavigationPage.SetHasNavigationBar(this, false);
	}
    private async void back_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopAsync();
    }
}