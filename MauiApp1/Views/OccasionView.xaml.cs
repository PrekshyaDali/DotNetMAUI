using CommunityToolkit.Maui.Views;

namespace MauiApp1.Views;

public partial class OccasionView : ContentPage
{
	public OccasionView()
	{
		InitializeComponent();
	}

    private async void OccasionPopUp_Clicked(object sender, EventArgs e)
    {
		var popup = new AssignmentPopUp();
		var result = await this.ShowPopupAsync(popup);
    }
}