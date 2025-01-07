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

namespace Lab10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Account> accounts = new List<Account>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CurrentAccount ca1 = new CurrentAccount()
            {
                Balance = 25000,
                AccountNumber = "123456",
                FirstName = "Sam",
                LastName = "Doe",
                InteresstDate = DateTime.Now.AddYears(-3),
            };
            CurrentAccount ca2 = new CurrentAccount()
            {
                Balance = 2000,
                AccountNumber = "12324567",
                FirstName = "Mary",
                LastName = "Doe",
                InteresstDate = DateTime.Now.AddYears(-2),
            };
            SavingsAccount sa1 = new SavingsAccount()
            {
                Balance = 4000,
                AccountNumber = "12345367",
                FirstName = "Mary",
                LastName = "Smith",
                InteresstDate = DateTime.Now.AddYears(-1),
            };
            SavingsAccount sa2 = new SavingsAccount()
            {
                Balance = 5000,
                AccountNumber = "1234567",
                FirstName = "John",
                LastName = "Smith",
                InteresstDate = DateTime.Now.AddYears(-4),
            };

            accounts.Add(ca1);
            accounts.Add(ca2);
            accounts.Add(sa1);
            accounts.Add(sa2);

            lbxAllData.ItemsSource = accounts;
        }

        private void lbxAllData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach(Account account in lbxAllData.SelectedItems)
            {

            }
        }
    }
}