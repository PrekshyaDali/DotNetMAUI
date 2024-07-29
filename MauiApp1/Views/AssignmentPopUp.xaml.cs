namespace MauiApp1.Views;
using CommunityToolkit.Maui.Views;
using MauiApp1.Models;

public partial class AssignmentPopUp : Popup
{
	public AssignmentPopUp()
	{
		InitializeComponent();
	}

    private void CancelButton_Clicked(object sender, EventArgs e)
    {
        Close();
    }

    private void SaveButton_Clicked(object sender, EventArgs e)
    {
        OccasionModel occasion = new OccasionModel {
            Date = OccasionDate.Date,
            Occasion = OccasionType.SelectedItem.ToString(),
            Notes = OccasionNotes.Text
        };
        Close(occasion);
    }
}