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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
       deskEntities entities=new deskEntities();
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            entities.USER_.Remove(entities.USER_.FirstOrDefault(x => x.PHONE == phone.Text));
            entities.SaveChanges();
            MessageBox.Show("done");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            page_2 page=new page_2();
            this.NavigationService.Navigate(page);
        }
    }
}
