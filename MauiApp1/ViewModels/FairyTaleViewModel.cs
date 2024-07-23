using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp1.Models;

namespace MauiApp1.ViewModels
{
     partial class FairyTaleViewModel: ObservableObject
    {
        public ObservableCollection<FairyTale> FairyTales1 { get; set; }
        public ObservableCollection<FairyTale> FairyTales2 { get; set; }

        public ObservableCollection<FairyTale> FilteredFairyTales1 { get; set; }
        public ObservableCollection<FairyTale> FilteredFairyTales2 { get; set; }

        [ObservableProperty]
        public bool isFilteredFairyTales1Visible;
        [ObservableProperty]
        public bool isFilteredFairyTales2Visible;

        public ICommand SearchCommand { get; }

        [ObservableProperty]
        public string searchText;

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

            FilteredFairyTales1 = new ObservableCollection<FairyTale>(FairyTales1);
            FilteredFairyTales2 = new ObservableCollection<FairyTale>(FairyTales2);
            SearchCommand = new RelayCommand(OnSearch);

        }

        private void OnSearch()
        {
  
            var filtered1 = FairyTales1.Where(f => f.Name.Contains(SearchText, StringComparison.OrdinalIgnoreCase)).ToList();
            var filtered2 = FairyTales2.Where(f => f.Name.Contains(SearchText, StringComparison.OrdinalIgnoreCase)).ToList();

            FilteredFairyTales1.Clear();
            FilteredFairyTales2.Clear();

            foreach (var fairyTale in filtered1)
            {
                FilteredFairyTales1.Add(fairyTale);
            }

            foreach (var fairyTale in filtered2)
            {
                FilteredFairyTales2.Add(fairyTale);
            }
            IsFilteredFairyTales1Visible = FilteredFairyTales1.Any();
            IsFilteredFairyTales2Visible = FilteredFairyTales2.Any();
        }

        public void OnCancel()
        {
            SearchText = string.Empty;
            FilteredFairyTales1 = new ObservableCollection<FairyTale>(FairyTales1);
            FilteredFairyTales2 = new ObservableCollection<FairyTale>(FairyTales2);
        }
    }
}
