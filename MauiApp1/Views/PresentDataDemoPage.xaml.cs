namespace MauiApp1.Views;

public partial class PresentDataDemoPage : ContentPage
{
	public PresentDataDemoPage()
	{
		InitializeComponent();
	}

    private void TermsCheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		if (e.Value)
		{
			StatusLabel.Text = "You have agreed to all the terms and condition";
		}
		else
		{
			StatusLabel.Text = "You have not agreed , please agreee";
		}



    }
}