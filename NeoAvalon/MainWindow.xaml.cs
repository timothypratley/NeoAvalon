using System.Windows;
using System.Windows.Input;
using WPFAppFramework;

namespace NeoAvalon
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CloseCmdCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CloseCmdExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void OpenCmdCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void OpenCmdExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            var wb = new DockableBrowser();
            wb.ShowAsDocument(dockManager);
            wb.Focus();
        }

        private void NewCmdCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private bool _loaded;
        private void NewCmdExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            if (!_loaded)
            {
                WPFAppWorld.Init(this, "user:Logs/NeoAvalon.log");
                WPFAppWorld.MapLoad("Maps/WindowsAppExample/Map.map", true);
                _loaded = true;
            }

            var view = new DockableNeoAxis();
            view.ShowAsDocument(dockManager);
            view.Focus();
        }
    }
}
