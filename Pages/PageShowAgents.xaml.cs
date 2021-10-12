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

        /// <summary>
        /// Подгрузка данных в БД, при загрузке страницы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

            lbAgents.ItemsSource = DBModel.DB.Agent.ToList();

            List<string> NamesToComboSorting = new List<string> { "Сортировка:", "От А до Я", "От Я до А" };

            foreach (var a in NamesToComboSorting)
            {
                cbSort.Items.Add(a).ToString();
            }

            cbFilter.Items.Add("Группировка:");
            foreach (var a in DBModel.DB.AgentType)
            {
                cbFilter.Items.Add(a).ToString();
            }

        }

        /// <summary>
        ///  Реализация поиска данных по БД в поисковой строке, при её изменении
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            lbAgents.ItemsSource = DBModel.DB.Agent.Where(x => x.Title.StartsWith(tbSearch.Text)).ToList(); 
        }

        /// <summary>
        /// Метод реализации сортировки данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (cbSort.SelectedIndex)
            {
                default:
                    lbAgents.ItemsSource = DBModel.DB.Agent.ToList();
                    break;
                case 0:
                    lbAgents.ItemsSource = DBModel.DB.Agent.ToList();
                    break;
                case 1: 
                    lbAgents.ItemsSource = DBModel.DB.Agent.OrderBy(u => u.Title).ToList();
                    break;
                case 2:
                    lbAgents.ItemsSource = DBModel.DB.Agent.OrderByDescending(u => u.Title).ToList();
                    break;
            }
        }

       /// <summary>
       /// Алгоритм реализации группировки данных
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
       private void cbFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            switch (cbFilter.SelectedIndex)
            {
                default:
                    lbAgents.ItemsSource = DBModel.DB.Agent.ToList();
                    break;
                case 0:
                    lbAgents.ItemsSource = DBModel.DB.Agent.ToList();
                    break;
                case 1:
                    lbAgents.ItemsSource = DBModel.DB.Agent.Where(u => u.AgentType.Title == "МКК").ToList();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
            }
        }
    }
}
