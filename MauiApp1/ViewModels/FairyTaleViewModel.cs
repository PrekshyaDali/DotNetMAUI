using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using MauiApp1.Models;

namespace MauiApp1.ViewModels
{
    class FairyTaleViewModel
    {
        public ObservableCollection<FairyTale> FairyTales1 { get; set; }
        public ObservableCollection<FairyTale> FairyTales2 { get; set; }

        public FairyTaleViewModel()
        {
            FairyTales1 = new ObservableCollection<FairyTale>
    {
        new FairyTale { Name = "TinkerBell", ReadTime = TimeSpan.FromMinutes(10), Image = "Fairies/tinkerbell.jpg" },
        new FairyTale { Name = "Cinderella", ReadTime = TimeSpan.FromMinutes(20), Image = "Fairies/cindrella.jpg" },
                
    }; 

            FairyTales2 = new ObservableCollection<FairyTale>
    {
        new FairyTale { Name = "Snow White", ReadTime = TimeSpan.FromMinutes(15), Image = "Fairies/snowwhite.jpg" },
        new FairyTale { Name = "Rapunzel", ReadTime = TimeSpan.FromMinutes(18), Image = "Fairies/rapunzel.jpg" },
        new FairyTale { Name = "Cinderella", ReadTime = TimeSpan.FromMinutes(20), Image = "Fairies/cindrella.jpg" },
        new FairyTale { Name = "Cinderella", ReadTime = TimeSpan.FromMinutes(20), Image = "Fairies/cindrella.jpg" },
        
    };
        }
    }
}
