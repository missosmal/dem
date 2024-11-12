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
    /// Логика взаимодействия для Element.xaml
    /// </summary>
    public partial class Element : UserControl
    {
        Classes.Classes _application;
        public Element(Classes.Classes _application)
        {
            InitializeComponent();
            this._application = _application;
            id.Content += _application.id.ToString();
            date.Content += _application.date.ToString("dd.MM.yyyy HH:mm:ss");
            application.Content += _application.application;
            typeDefect.Content += _application.typeDefect;
            description.Text += _application.description;
            client.Content += _application.client;
            status.Content += _application.status;
            avgTime.Content += _application.avgTime.ToString();
        }

        private void redacClick(object sender, RoutedEventArgs e)
        {
            MainWindow.mainWindow.frame.Navigate(new Pages.Add(_application));
        }
    }
}
