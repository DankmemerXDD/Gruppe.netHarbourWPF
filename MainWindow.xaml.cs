using System.Windows;

namespace Gruppe.netHarbourWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DockSpace_Click(object sender, RoutedEventArgs e)
        {
            // Code for DockSpace action
            MessageBox.Show("DockSpace clicked!");
        }

        private void ContainerYard_Click(object sender, RoutedEventArgs e)
        {
            // Code for ContainerYard action
            MessageBox.Show("ContainerYard clicked!");
        }
    }
}