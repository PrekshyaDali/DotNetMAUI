using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace MauiApp1.Models
{
    public class ChangeColorAction : TriggerAction<Entry>
    {

        protected override void Invoke(Entry entry)
        {
            //entry.TextColor = Colors.Red;
            //entry.BackgroundColor = Colors.Green;
        }
    }
}
