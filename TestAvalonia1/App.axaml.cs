using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using TestAvalonia1.ViewModels;
using TestAvalonia1.Views;

namespace TestAvalonia1
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow
                {
                    DataContext = new MainWindowViewModel(),
                };

                ((MainWindow)desktop.MainWindow).mainWindowViewModel = desktop.MainWindow.DataContext as MainWindowViewModel;
                ((MainWindow)desktop.MainWindow).mainWindowViewModel.mainWindow = desktop.MainWindow as MainWindow;
                ((MainWindow)desktop.MainWindow).mainWindowViewModel.Init();

                ((MainWindow)desktop.MainWindow).mainWindowViewModel.popupWindow.DataContext = new PopupWindowViewModel();
                ((PopupWindowViewModel)((MainWindow)desktop.MainWindow).mainWindowViewModel.popupWindow.DataContext)
                    .popupWindow
                    = ((MainWindow)desktop.MainWindow).mainWindowViewModel.popupWindow;
                ((PopupWindowViewModel)((MainWindow)desktop.MainWindow).mainWindowViewModel.popupWindow.DataContext).Init();

            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}