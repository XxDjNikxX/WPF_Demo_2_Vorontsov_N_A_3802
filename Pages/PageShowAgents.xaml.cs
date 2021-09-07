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

namespace WPF_Demo_1_Vorontsov_N_A_3802.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageShowAgents.xaml
    /// </summary>
    public partial class PageShowAgents : Page
    {
        public PageShowAgents()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dbAgents.ItemsSource =  DBModel.DB.Agent.ToList();

        }
    }
}
