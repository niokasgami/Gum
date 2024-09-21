using Gum.Managers;
using Gum2.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gum2.Plugins.MvvmExamplePlugin.ViewModels
{
    public class MainViewModel : ViewModel
    {
        public string Name
        {
            get => Get<string>();
            set => Set(value);
            //get;
            //set;
        }

        public bool IsDefinedByBase
        {
            get => Get<bool>();
            set => Set(value);
        }

        public bool IsLocked
        {
            get => Get<bool>();
            set => Set(value);
        }

        [DependsOn(nameof(IsLocked))]
        public bool IsUiEnabled => !IsLocked;

    }
}
