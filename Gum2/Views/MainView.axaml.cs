using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Gum2.Commands;

namespace Gum2.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();

        GumCommands.Self.Initialize(
            this.LeftTabControl,
            this.MiddleTopTabControl,
            this.MiddleBottomTabControl,
            this.RightTopTabControl,
            this.RightBottomTabControl);
    }
}