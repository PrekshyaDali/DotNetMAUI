//using Microsoft.Maui.Controls;
//using Microsoft.Maui.Graphics;

//namespace MauiApp1.Models
//{
//    public class ChangeColorAction : TriggerAction<Entry>
//    {

//        protected override void Invoke(Entry entry)
//        {
//            entry.TextColor = Colors.Red;
//            entry.BackgroundColor = Colors.Green;
//        }
//    }
//}
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace MauiApp1.Models
{
    public class ChangeColorAction : TriggerAction<Entry>
    {
        public Color FocusedTextColor { get; set; } = Colors.Red;
        public Color FocusedBackgroundColor { get; set; } = Colors.Green;
        public Color UnfocusedTextColor { get; set; } = Colors.Black;
        public Color UnfocusedBackgroundColor { get; set; } = Colors.Transparent;

        protected override void Invoke(Entry entry)
        {
            if (entry.IsFocused)
            {
                entry.TextColor = FocusedTextColor;
                entry.BackgroundColor = FocusedBackgroundColor;
            }
            else
            {
                entry.TextColor = UnfocusedTextColor;
                entry.BackgroundColor = UnfocusedBackgroundColor;
            }
        }
    }
}
