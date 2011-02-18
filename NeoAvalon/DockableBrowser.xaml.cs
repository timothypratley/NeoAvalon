using System;

namespace NeoAvalon
{
    /// <summary>
    /// Interaction logic for DockableBrowser.xaml
    /// </summary>
    public partial class DockableBrowser
    {
        public DockableBrowser()
        {
            InitializeComponent();
            myBrowser.Navigate(new Uri("http://gr1d.org"));
        }
    }
}
