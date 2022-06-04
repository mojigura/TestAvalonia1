using System;
using System.Collections.Generic;
using System.Text;
using TestAvalonia1.Views;

namespace TestAvalonia1.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindow? mainWindow = null;
        public string Greeting => "Welcome to Avalonia!";
        public PopupWindow popupWindow = new PopupWindow();
        private bool bCloseMainWindow = false; 


        public void Init()
        {
            popupWindow.Closing += PopupWindow_Closing;
            mainWindow.Closing += MainWindow_Closing;
        }

        private void MainWindow_Closing(object? sender, System.ComponentModel.CancelEventArgs e)
        {
            bCloseMainWindow = true;
            popupWindow.Close();
        }

        private void PopupWindow_Closing(object? sender, System.ComponentModel.CancelEventArgs e)
        {
            ((PopupWindow)popupWindow).Hide();
            e.Cancel = !bCloseMainWindow;
        }

        public void OnCommand_Test1()
        {
            popupWindow.Show();
        }


    }
}
