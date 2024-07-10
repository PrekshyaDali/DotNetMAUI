using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MauiApp1.Pages;

public partial class BindableLayoutDemo : ContentPage
{
    public ObservableCollection<string> MyStrings { get; set; }

    public ICommand ClearCommand { get; set; }

    public BindableLayoutDemo()
    {
        InitializeComponent();

        MyStrings = new ObservableCollection<string>
        {
            "Hey, This is Prekshya",
            "I am a trainee at Bajra",
            "I am learning MAUI"
        };

        ClearCommand = new Command(() => MyStrings.Clear());

        BindingContext = this;
    }
}
