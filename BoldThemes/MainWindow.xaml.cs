using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DragonJetzFramework.Themes;

namespace DragonJetzFramework {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void ChangeTheme(object sender, RoutedEventArgs e) {
            ThemeType theme;
            switch (int.Parse(((MenuItem)sender).Uid)) {
                case 0:
                    theme = ThemeType.Light;
                    break;
                case 1:
                    theme = ThemeType.Dark;
                    break;
                case 2:
                    theme = ThemeType.Red;
                    break;
                default:
                    return;
            }

            ThemesController.SetTheme(theme);
        }
    }
}
