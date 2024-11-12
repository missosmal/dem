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
    /// Логика взаимодействия для Status.xaml
    /// </summary>
    public partial class Status : Page
    {
        public Status()
        {
            InitializeComponent();
            int countStatusIsDone = 0;
            foreach(var item in Classes.Classes.allApplication.Where(x => x.status == "Выполнено"))
            {
                countStatusIsDone++;
            }
            status.Content += countStatusIsDone.ToString();
            double avg = 0;
            double countApplication = 0;
            foreach (var item in Classes.Classes.allApplication)
            {
                avg += item.avgTime;
                countApplication++;
            }
            avgTime.Content += avg / countApplication + " часа(-ов)";
            list.Items.Clear();
            list.ItemsSource = Classes.Classes.allApplication.GroupBy(x => x.typeDefect).OrderByDescending(x => x.Count()).Select(x => $"{x.Key}: {x.Count()}");
        }

        private void backPage(object sender, RoutedEventArgs e)
        {
            MainWindow.mainWindow.frame.Navigate(new Pages.Main());
        }
    }
}
