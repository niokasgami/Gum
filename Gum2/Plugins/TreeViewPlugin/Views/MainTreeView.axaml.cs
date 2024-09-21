using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Gum2;

public partial class MainTreeView : UserControl
{
    public MainTreeView()
    {
        InitializeComponent();

        for (int i = 0; i < 100; i++)
        {
            TreeViewInstance.Items.Add(i);
        }
    }
}