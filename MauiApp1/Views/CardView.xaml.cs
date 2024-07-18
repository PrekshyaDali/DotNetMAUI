namespace MauiApp1.Views;
using Microsoft.Maui.Controls;
public partial class CardView : ContentView
{

    public static readonly BindableProperty CardTitleProperty = BindableProperty.Create(
        nameof(CardTitle), typeof(string), typeof(CardView), string.Empty);

    public string CardTitle
    {
        get => (string)GetValue(CardTitleProperty);
        set => SetValue(CardTitleProperty, value);
    }

    public static readonly BindableProperty DescriptionProperty = BindableProperty.Create(
      nameof(Description), typeof(string), typeof(CardView), string.Empty);

    public string Description
    {
        get => (string)GetValue(DescriptionProperty);
        set => SetValue(DescriptionProperty, value);
    }

    public static readonly BindableProperty ProfileImageSourceProperty = BindableProperty.Create(
        nameof(ProfileImageSource), typeof(ImageSource), typeof(CardView), default(ImageSource));

    public ImageSource ProfileImageSource
    {
        get => (ImageSource)GetValue(ProfileImageSourceProperty);
        set => SetValue(ProfileImageSourceProperty, value);
    }
    public CardView()
    {
        InitializeComponent();
        BindingContext = this;
    }
}