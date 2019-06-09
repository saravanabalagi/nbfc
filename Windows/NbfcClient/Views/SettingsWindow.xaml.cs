using MahApps.Metro.Controls;
using System.Diagnostics;
using System.Windows;

namespace NbfcClient.Windows
{
    /// <summary>
    /// Interaction logic for SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : MetroWindow
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void StackPanel_MouseLeftButtonUp_Profile(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Process.Start("https://www.github.com/saravanabalagi");
        }

        private void StackPanel_MouseLeftButtonUp_Repo(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Process.Start("https://www.github.com/saravanabalagi/nbfc");
        }

        private void StackPanel_MouseLeftButtonUp_Fork(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Process.Start("https://www.github.com/hirschmann/nbfc");
        }
    }
}
