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

namespace MySimpleAccount_2._0
{
    /// <summary>
    /// Логика взаимодействия для EditAccountPage.xaml
    /// </summary>
    public partial class EditAccountPage : Page
    {
        public EditAccountPage()
        {
            InitializeComponent();
            DataContext = new EditAccountViewModel();
        }
        public EditAccountPage(Account selectedAccount)
        {
            InitializeComponent();
            DataContext = new EditAccountViewModel(selectedAccount);
        }
    }
}
