using MauiApp1.Views;
namespace MauiApp1.Pages
{
    public partial class StackLayoutDemo : ContentPage
    {
        public StackLayoutDemo()
        {
            InitializeComponent();
        }

        private void HorizontalStackLayoutButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HorizontalStackLayoutDemo());
        }

        private void VerticalStackLayoutButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new VerticalStackLayoutDemo());
        }

        private void gridlayoutDemo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GridLayoutDemo());

        }

        private void absoluteLayoutDemo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AbsoluteLayoutDemo());

        }

        private void flexLayoutDemo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FlexLayoutDemo());

        }

        private void bindableLayoutDemo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BindableLayoutDemo());

        }

    }
}
