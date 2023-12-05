using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for forgetpass.xaml
    /// </summary>
    public partial class forgetpass : Page
    {
        deskEntities entities = new deskEntities();
        public forgetpass()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            USER_ uSER_ = entities.USER_.FirstOrDefault(x => x.PHONE == phone.Text);
            var c = IsValid(newpass.Password);
            if (uSER_ == null)
            {
                MessageBox.Show("invalid phone");
            }
            else if (uSER_ != null)
            {
                pass.Text = uSER_.PASSWORD_;

                if (newpass.Password == cpass.Password&&c==true)
                {
                    uSER_.PASSWORD_ = newpass.Password;
                    entities.USER_.AddOrUpdate(uSER_);
                    entities.SaveChanges();
                    MessageBox.Show("update");
                    newpass.Password = pass.Text = cpass.Password =phone.Text ="";

                    log_in log_In = new log_in();
                    this.NavigationService.Navigate(log_In);
                }
                else
                {
                    MessageBox.Show("invalid");
                }
            }
        }
        bool IsValid(string pass)
        {
            bool z, x, c;
            z = x = c = false;
            string sub = "@#$%^&*()";
            foreach (char cc in pass)
            {
                if (cc >= 'a' && cc <= 'z')
                {
                    z = true;
                }
                else if (cc >= '0' && cc <= '9')
                {
                    x = true;
                }
                else if (sub.Contains(cc))
                {
                    c = true;
                }
            }
            return z & z & x & c;
        }

    }
}
