using CommunityToolkit.Maui.Views;
using MauiApp1.Models;
using System.Collections.ObjectModel;

namespace MauiApp1.Views;

public partial class OccasionView : ContentPage
{
	private ObservableCollection<OccasionModel> _OccasionModels;
	public OccasionView()
	{
		InitializeComponent();
		_OccasionModels = new ObservableCollection<OccasionModel>();
	}

    private async void OccasionPopUp_Clicked(object sender, EventArgs e)
    {
		var popup = new AssignmentPopUp();
		var result = await this.ShowPopupAsync(popup);
		var occasion = (OccasionModel)result;

		_OccasionModels.Add(occasion);
		OccasionList.ItemsSource = _OccasionModels;
    }
}
