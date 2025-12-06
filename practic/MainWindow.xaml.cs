using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace practic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Close();
        }

        private void TextBox_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (loginInput.Text == "Логин")
            {
                loginInput.Text = string.Empty;
            }
            if (passwordInput.Text == "")
            {
                passwordInput.Text = "Пароль";
            }
        }

        private void passwordInput_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (loginInput.Text == "")
            {
                loginInput.Text = "Логин";
            }
            if (passwordInput.Text == "Пароль")
            {
                passwordInput.Text = string.Empty;
            }
        }
    }
}