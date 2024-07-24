namespace MauiApp1.Views;

public partial class FileHandlingDemoPage : ContentPage
{
	public FileHandlingDemoPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        var options = new PickOptions
        {
            PickerTitle = "Please select a file",
            FileTypes = FilePickerFileType.Images
        };

        try
        {
            var result = await FilePicker.Default.PickAsync(options);

            if (result != null)
            {
                if (result.FileName.EndsWith("jpg", StringComparison.OrdinalIgnoreCase) ||
                    result.FileName.EndsWith("png", StringComparison.OrdinalIgnoreCase))
                {
                    using var stream = await result.OpenReadAsync();
                    var imageSource = ImageSource.FromStream(() => stream);
                }
            }
        }
        catch (Exception ex)
        {
        }
    }
}