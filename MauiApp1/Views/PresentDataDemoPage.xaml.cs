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

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		double value = (double)e.NewValue;
        rotatingLabel.Rotation = value;
		displayLabel.Text = String.Format("The slider Value is {0)", value);

    }
}