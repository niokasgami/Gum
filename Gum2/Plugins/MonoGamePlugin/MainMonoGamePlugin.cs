using Gum.Plugins.BaseClasses;
using Gum2.Commands;
using Gum2.Plugins.MonoGamePlugin.ViewModels;
using System.ComponentModel.Composition;

namespace Gum2.Plugins.MonoGamePlugin
{
    [Export(typeof(PluginBase))]
    internal class MainMonoGamePlugin : InternalPlugin
    {
        public override void StartUp()
        {
            var viewModel = new MonoGameViewModel();
            var control = new MonoGameView();
            control.DataContext = viewModel;

            GumCommands.Self.GuiCommands.AddControl(control, "MonoGameView", TabLocation.CenterBottom);
        }
    }
}
