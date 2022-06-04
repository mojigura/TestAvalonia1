using Avalonia.Controls;
using TestAvalonia1.ViewModels;

namespace TestAvalonia1.Views
{
    public partial class MainWindow : Window
    {
        public MainWindowViewModel? mainWindowViewModel = null;
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}