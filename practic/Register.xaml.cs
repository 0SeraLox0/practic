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
using System.Windows.Shapes;

namespace practic
{
    /// <summary>
    /// Логика взаимодействия для Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void text_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (NameInput.Text == string.Empty)
            {
                NameInput.Text = "Имя";
            }
            if (SurnameInput.Text == string.Empty)
            {
                SurnameInput.Text = "Фамилия";
            }
            if (LoginInput.Text == string.Empty)
            {
                LoginInput.Text = "Логин";
            }
            if (PasswordInput.Text == string.Empty)
            {
                PasswordInput.Text = "Пароль";
            }
            if (PhoneInput.Text == string.Empty)
            {
                PhoneInput.Text = "Телефон";
            }
            if (MailInput.Text == string.Empty)
            {
                MailInput.Text = "Почта";
            }
        }

        private void NameInput_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (NameInput.Text == "Имя")
            {
                NameInput.Text = string.Empty;
            }
        }

        private void SurnameInput_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (SurnameInput.Text == "Фамилия")
            {
                SurnameInput.Text = string.Empty;
            }
        }

        private void LoginInput_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (LoginInput.Text == "Логин")
            {
                LoginInput.Text = string.Empty;
            }
        }

        private void PasswordInput_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (PasswordInput.Text == "Пароль")
            {
                PasswordInput.Text = string.Empty;
            }
        }

        private void PhoneInput_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (PhoneInput.Text == "Телефон")
            {
                PhoneInput.Text = string.Empty;
            }
        }

        private void MailInput_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (MailInput.Text == "Почта")
            {
                MailInput.Text = string.Empty;
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
