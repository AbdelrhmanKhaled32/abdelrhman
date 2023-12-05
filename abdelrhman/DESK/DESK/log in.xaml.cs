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
    /// Interaction logic for log_in.xaml
    /// </summary>
    public partial class log_in : Page
    {
        deskEntities entities = new deskEntities();
        public log_in()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            USER_ sER_ = entities.USER_.FirstOrDefault(x => x.NAME_ == user.Text && x.PASSWORD_ == pass.Password);
            if(sER_ == null)
            {
                MessageBox.Show("invalid password or name");
            }
            else if(sER_ != null)
            {
                MessageBox.Show("valid");
                profile profile = new profile();
                this.NavigationService.Navigate(profile);
                profile.nameu.Content = user.Text;
                profile.user.Text = sER_.NAME_;
                profile.pass.Password = sER_.PASSWORD_;
                profile.Age.Text = Convert.ToString(sER_.AGE);
                profile.gender.Text = sER_.GENDER;
                profile.city.Text = sER_.CITY;
                profile.phone.Text = sER_.PHONE;
                user.Text = pass.Password = "";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            sign_up sign_Up = new sign_up();
            this.NavigationService.Navigate(sign_Up);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            forgetpass forgetpass = new forgetpass();
            this.NavigationService.Navigate(forgetpass);
        }
    }
}
