using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Gum2.Plugins.MvvmExamplePlugin.ViewModels;

namespace Gum2;

public partial class UserControl1 : UserControl
{
    public UserControl1()
    {
        InitializeComponent();
    }

    private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        // todo - we need to clear this out...
        var viewModel = (MainViewModel)DataContext;

        viewModel.Name = "";
        viewModel.IsDefinedByBase = false;
        viewModel.IsLocked = false;

    }
}