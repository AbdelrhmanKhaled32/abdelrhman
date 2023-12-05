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

namespace DESK
{
    /// <summary>
    /// Interaction logic for page_2.xaml
    /// </summary>
    public partial class page_2 : Page
    {
        deskEntities entities = new deskEntities();
        public page_2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Page1 page =new Page1();
            this.NavigationService.Navigate(page);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            dg.ItemsSource=entities.USER_.Where(x=>x.CITY==city.Text).ToList();
        }
    }
}
