using Avalonia.Controls;
using Gum.Plugins;

namespace Gum2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            PluginManager.Self.Initialize();

        }
    }
}