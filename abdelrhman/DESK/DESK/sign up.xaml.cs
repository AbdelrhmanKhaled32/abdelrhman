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
    /// Interaction logic for sign_up.xaml
    /// </summary>
    public partial class sign_up : Page
    {
        deskEntities entities = new deskEntities();
        public sign_up()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            USER_ uSER_=new USER_();
            log_in log_In = new log_in();
            int agey = int.Parse(Age.Text);
            var ss = IsValid(pass.Password);
            switch (combo.Text)
            {
                case "cairo":
                    if (male.IsChecked == true)
                    {
                        if (phone.Text.Length == 11)
                        {
                            if (agey >= 16 && agey <= 60)
                            {
                                if (ss == true)
                                {
                                    uSER_.NAME_ = user.Text;
                                    uSER_.PASSWORD_ = pass.Password;
                                    uSER_.GENDER = "Male";
                                    uSER_.CITY = "Cairo";
                                    uSER_.AGE = int.Parse(Age.Text);
                                    uSER_.PHONE = phone.Text;
                                    entities.USER_.Add(uSER_);
                                    entities.SaveChanges();
                                    this.NavigationService.Navigate(log_In);
                                    MessageBox.Show("valid");
                                }
                                else if (ss != true)
                                {
                                    MessageBox.Show("invalid password");
                                }
                            }
                            else
                            {
                                MessageBox.Show("invalid age");
                            }

                        }
                        else
                        {
                            MessageBox.Show("invalid phone");
                        }
                    }
                    else if (female.IsChecked == true)
                    {
                        if (phone.Text.Length == 11)
                        {
                            if (agey >= 16 && agey <= 60)
                            {
                                if (ss == true)
                                {
                                    uSER_.NAME_ = user.Text;
                                    uSER_.PASSWORD_ = pass.Password;
                                    uSER_.GENDER = "Female";
                                    uSER_.CITY = "Cairo";
                                    uSER_.AGE = int.Parse(Age.Text);
                                    uSER_.PHONE = phone.Text;
                                    entities.USER_.Add(uSER_);
                                    entities.SaveChanges();
                                    this.NavigationService.Navigate(log_In);
                                    MessageBox.Show("valid");
                                }
                                else if (ss != true)
                                {
                                    MessageBox.Show("invalid password");
                                }
                            }
                            else
                            {
                                MessageBox.Show("invalid age");
                            }
                        }
                        else
                        {
                            MessageBox.Show("invalid phone");
                        }
                    }
                    break;
                case "giza":
                    if (male.IsChecked == true)
                    {
                        if (phone.Text.Length == 11)
                        {
                            if (agey >= 16 && agey <= 60)
                            {
                                if (ss == true)
                                {
                                    uSER_.NAME_ = user.Text;
                                    uSER_.PASSWORD_ = pass.Password;
                                    uSER_.GENDER = "Male";
                                    uSER_.CITY = "giza";
                                    uSER_.AGE = int.Parse(Age.Text);
                                    uSER_.PHONE = phone.Text;
                                    entities.USER_.Add(uSER_);
                                    entities.SaveChanges();
                                    this.NavigationService.Navigate(log_In);

                                    MessageBox.Show("valid");
                                }
                                else if (ss != true)
                                {
                                    MessageBox.Show("invalid password");
                                }
                            }
                            else
                            {
                                MessageBox.Show("invalid age");
                            }
                        }
                        else
                        {
                            MessageBox.Show("invalid phone");
                        }
                    }
                    else if (female.IsChecked == true)
                    {
                        if (phone.Text.Length == 11)
                        {
                            if (agey >= 16 && agey <= 60)
                            {
                                if (ss == true)
                                {
                                    uSER_.NAME_ = user.Text;
                                    uSER_.PASSWORD_ = pass.Password;
                                    uSER_.GENDER = "Female";
                                    uSER_.CITY = "giza";
                                    uSER_.AGE = int.Parse(Age.Text);
                                    uSER_.PHONE = phone.Text;
                                    entities.USER_.Add(uSER_);
                                    entities.SaveChanges();
                                    this.NavigationService.Navigate(log_In);
                                    MessageBox.Show("valid");
                                }
                                else if (ss != true)
                                {
                                    MessageBox.Show("invalid password");
                                }
                            }
                            else
                            {
                                MessageBox.Show("invalid age");
                            }
                        }
                        else
                        {
                            MessageBox.Show("invalid phone");
                        }
                    }
                    break;
                case "paris":
                    if (male.IsChecked == true)
                    {
                        if (phone.Text.Length == 11)
                        {
                            if (agey >= 16 && agey <= 60)
                            {
                                if (ss == true)
                                {
                                    uSER_.NAME_ = user.Text;
                                    uSER_.PASSWORD_ = pass.Password;
                                    uSER_.GENDER = "Male";
                                    uSER_.CITY = "paris";
                                    uSER_.AGE = int.Parse(Age.Text);
                                    uSER_.PHONE = phone.Text;
                                    entities.USER_.Add(uSER_);
                                    entities.SaveChanges();
                                    this.NavigationService.Navigate(log_In);
                                    MessageBox.Show("valid");
                                }
                                else if (ss != true)
                                {
                                    MessageBox.Show("invalid password");
                                }
                            }
                            else
                            {
                                MessageBox.Show("invalid age");
                            }
                        }
                        else
                        {
                            MessageBox.Show("invalid phone");
                        }
                    }
                    else if (female.IsChecked == true)
                    {
                        if (phone.Text.Length == 11)
                        {
                            if (agey >= 16 && agey <= 60)
                            {
                                if (ss == true)
                                {
                                    uSER_.NAME_ = user.Text;
                                    uSER_.PASSWORD_ = pass.Password;
                                    uSER_.GENDER = "Female";
                                    uSER_.CITY = "paris";
                                    uSER_.AGE = int.Parse(Age.Text);
                                    uSER_.PHONE = phone.Text;
                                    entities.USER_.Add(uSER_);
                                    entities.SaveChanges();
                                    this.NavigationService.Navigate(log_In);
                                    MessageBox.Show("valid");
                                }
                                else if (ss != true)
                                {
                                    MessageBox.Show("invalid password");
                                }
                            }
                            else
                            {
                                MessageBox.Show("invalid age");
                            }
                        }
                        else
                        {
                            MessageBox.Show("invalid phone");
                        }
                    }
                    break;
                case " aswan":
                    if (male.IsChecked == true)
                    {
                        if (phone.Text.Length == 11)
                        {
                            if (agey >= 16 && agey <= 60)
                            {
                                if (ss == true)
                                {
                                    uSER_.NAME_ = user.Text;
                                    uSER_.PASSWORD_ = pass.Password;
                                    uSER_.GENDER = "Male";
                                    uSER_.CITY = "aswan";
                                    uSER_.AGE = int.Parse(Age.Text);
                                    uSER_.PHONE = phone.Text;
                                    entities.USER_.Add(uSER_);
                                    entities.SaveChanges();
                                    this.NavigationService.Navigate(log_In);
                                    MessageBox.Show("valid");
                                }
                                else if (ss != true)
                                {
                                    MessageBox.Show("invalid password");
                                }
                            }
                            else
                            {
                                MessageBox.Show("invalid age");
                            }
                        }
                        else
                        {
                            MessageBox.Show("invalid phone");
                        }
                    }
                    else if (female.IsChecked == true)
                    {
                        if (phone.Text.Length == 11)
                        {
                            if (agey >= 16 && agey <= 60)
                            {
                                if (ss == true)
                                {
                                    uSER_.NAME_ = user.Text;
                                    uSER_.PASSWORD_ = pass.Password;
                                    uSER_.GENDER = "Female";
                                    uSER_.CITY = "aswan";
                                    uSER_.AGE = int.Parse(Age.Text);
                                    uSER_.PHONE = phone.Text;
                                    entities.USER_.Add(uSER_);
                                    entities.SaveChanges();
                                    this.NavigationService.Navigate(log_In);
                                    MessageBox.Show("valid");
                                }
                                else if (ss != true)
                                {
                                    MessageBox.Show("invalid password");
                                }
                            }
                            else
                            {
                                MessageBox.Show("invalid age");
                            }
                        }
                        else
                        {
                            MessageBox.Show("invalid phone");
                        }
                    }
                    break;
                case "alex":
                    if (male.IsChecked == true)
                    {
                        if (phone.Text.Length == 11)
                        {
                            if (agey >= 16 && agey <= 60)
                            {
                                if (ss == true)
                                {
                                    uSER_.NAME_ = user.Text;
                                    uSER_.PASSWORD_ = pass.Password;
                                    uSER_.GENDER = "Male";
                                    uSER_.CITY = "alex";
                                    uSER_.AGE = int.Parse(Age.Text);
                                    uSER_.PHONE = phone.Text;
                                    entities.USER_.Add(uSER_);
                                    entities.SaveChanges();
                                    this.NavigationService.Navigate(log_In);
                                    MessageBox.Show("valid");
                                }
                                else if (ss != true)
                                {
                                    MessageBox.Show("invalid password");
                                }
                            }
                            else
                            {
                                MessageBox.Show("invalid age");
                            }
                        }
                        else
                        {
                            MessageBox.Show("invalid phone");
                        }
                    }
                    else if (female.IsChecked == true)
                    {
                        if (phone.Text.Length == 11)
                        {
                            if (agey >= 16 && agey <= 60)
                            {
                                if (ss == true)
                                {
                                    uSER_.NAME_ = user.Text;
                                    uSER_.PASSWORD_ = pass.Password;
                                    uSER_.GENDER = "Female";
                                    uSER_.CITY = "alex";
                                    uSER_.AGE = int.Parse(Age.Text);
                                    uSER_.PHONE = phone.Text;
                                    entities.USER_.Add(uSER_);
                                    entities.SaveChanges();
                                    this.NavigationService.Navigate(log_In);
                                    MessageBox.Show("valid");
                                }
                                else if (ss != true)
                                {
                                    MessageBox.Show("invalid password");
                                }
                            }
                            else
                            {
                                MessageBox.Show("invalid age");
                            }
                        }
                        else
                        {
                            MessageBox.Show("invalid phone");
                        }
                    }
                    break;
                   
            }
      
        }
        bool IsValid(string pass)
        {
            bool z, x, c;
            z=x=c=false;
            string sub = "@#$%^&*()";
            foreach(char cc in pass)
            {
                if (cc >= 'a' && cc <= 'z')
                {
                    z = true;
                }
                else if(cc >= '0' && cc <= '9')
                {
                    x=true;
                }
                else if(sub.Contains(cc))
                {
                    c = true;
                }
            }
            return z&z&x&c;
        }
    }
}
