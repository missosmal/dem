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

namespace dem
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow mainWindow;
        
        public MainWindow()
        {
            InitializeComponent();
            int n = 10;
            while (n >= 0) { MessageBox.Show("Надо делать самому!!!"); n--; }
            mainWindow = this;
            frame.Navigate(new Pages.Main());
        }
    }
}
