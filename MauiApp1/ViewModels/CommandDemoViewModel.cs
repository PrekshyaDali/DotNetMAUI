using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using MauiApp1.Models;
using System.Windows.Input;

using System.Threading.Tasks;

namespace MauiApp1.ViewModels
{
    internal class CommandDemoViewModel
    {
        public ObservableCollection<CommandDemo> Company { get; set; }

        public ICommand AddCompanyDetailsCommand { get; }

        public CommandDemoViewModel() {
            Company = new ObservableCollection<CommandDemo>();
            AddCompanyDetailsCommand = new Command(AddCompanyDetails);
        }
        public void AddCompanyDetails()
        {
            Company.Add(new CommandDemo { CompanyName = "Bajra Technologies", CompanyAge = 13 });

        }
    }
}
