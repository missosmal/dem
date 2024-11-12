using dem.Classes;
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
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : Page
    {
        Classes.Classes _application;
        public Add(Classes.Classes _application = null)
        {
            InitializeComponent();
            this._application = _application;
            if (_application != null) 
            {
                application.IsEnabled = false;
                typeDefect.IsEnabled = false;
                client.IsEnabled = false;
                avgTime.IsEnabled = false;
                application.Text = _application.application;
                typeDefect.Text = _application.typeDefect;
                description.Text = _application.description;
                client.Text = _application.client;
                status.Text = _application.status;
                avgTime.Text = _application.avgTime.ToString();
                addBtn.Content = "Изменить";
            }
        }

        private void addApplication(object sender, RoutedEventArgs e)
        {
            try
            {
                string statusChange = "";
                var newApplication = _application ?? new Classes.Classes()
                {
                    id = Classes.Classes.allApplication.Max(x => x.id) + 1,
                    date = DateTime.Now
                };
                statusChange = newApplication.status;
                newApplication.application = application.Text;
                newApplication.typeDefect = typeDefect.Text;
                newApplication.description = description.Text;
                newApplication.client = client.Text;
                newApplication.status = status.Text;
                newApplication.avgTime = Convert.ToInt32(avgTime.Text);
                if (_application != null && statusChange != newApplication.status)
                    MessageBox.Show($"Статус заявки №{_application.id} с '{statusChange}' на '{newApplication.status}'!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                if(_application == null)
                    Classes.Classes.allApplication.Add(newApplication);
                MainWindow.mainWindow.frame.Navigate(new Pages.Main());
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backPage(object sender, RoutedEventArgs e)
        {
            MainWindow.mainWindow.frame.Navigate(new Pages.Main());
        }
    }
}
