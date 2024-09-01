using Microsoft.UI.Xaml;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace R3WinUITest;

/// <summary>
/// An empty window that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class MainWindow : Window
{

    public ReactivePropertyViewModel ReactivePropertyViewModel { get; } = new();
    public R3ViewModel R3ViewModel { get; } = new();
    public MainWindow()
    {
        this.InitializeComponent();
    }
}
