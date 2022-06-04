using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace TestAvalonia1.Views
{
    public partial class PopupWindow : Window
    {
        public PopupWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
