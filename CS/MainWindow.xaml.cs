using DevExpress.Xpf.Core;
using System.Windows;

namespace EnableCustomSql {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        void UseDataSourceWizardSettings(object sender, RoutedEventArgs e) {
            new DXTabbedWindow() { Content = new UseDataSourceWizardSettings() }.ShowDialog();
        }

        void UseCustomization(object sender, RoutedEventArgs e) {
            new DXTabbedWindow() { Content = new UseCustomization() }.ShowDialog();
        }
    }
}
