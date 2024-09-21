using Gum.Plugins.BaseClasses;
using Gum2.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gum2.Plugins.MvvmExamplePlugin
{
    [Export(typeof(PluginBase))]
    public class MainMvvmExamplePlugin : InternalPlugin
    {
        public override void StartUp()
        {
            var viewModel = new ViewModels.MainViewModel();
            var control = new UserControl1();

            control.DataContext = viewModel;

            GumCommands.Self.GuiCommands.AddControl(control, "Example MVVM", TabLocation.CenterTop);
        }
    }
}
