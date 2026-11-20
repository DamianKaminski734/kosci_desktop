using Gra_w_kości_2026_desktop.ViewModels;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Gra_w_kości_2026_desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            KoscViewModel viewModel = new();

            DataContext = viewModel;
        }

        private void kosc_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Image image = (sender as Image)!;
            if (image.Opacity == 1d)
                image.Opacity = 0.5d;
            else
                image.Opacity = 1d;

            (DataContext as KoscViewModel)!.kosci[int.Parse(image.Tag.ToString()!)].CzyDostepna = !(DataContext as KoscViewModel)!.kosci[int.Parse(image.Tag.ToString()!)].CzyDostepna;
        }
    }
}