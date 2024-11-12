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

namespace dem.Pages
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public Main()
        {
            InitializeComponent();
            LoadItem();
        }

        private void LoadItem()
        {
            parent.Children.Clear();
            foreach (var item in Classes.Classes.allApplication.OrderBy(x => x.id))
                parent.Children.Add(new Pages.Element(item));
        }

        private void statusClick(object sender, RoutedEventArgs e)
        {
            MainWindow.mainWindow.frame.Navigate(new Pages.Status());
        }

        private void addClick(object sender, RoutedEventArgs e)
        {
            MainWindow.mainWindow.frame.Navigate(new Pages.Add());
        }

        private void searchTBChange(object sender, TextChangedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(search.Text))
            {
                string searchItem = search.Text.ToLower();
                parent.Children.Clear();
                foreach (var searchItems in Classes.Classes.allApplication.Where(x => x.id.ToString() == searchItem || x.application.ToLower().Contains(searchItem) || x.typeDefect.ToLower().Contains(searchItem) || x.description.ToLower().Contains(searchItem) || x.client.ToLower().Contains(searchItem) || x.status.ToLower().Contains(searchItem)))
                    parent.Children.Add(new Pages.Element(searchItems));
            }
            else LoadItem();
        }
    }
}
