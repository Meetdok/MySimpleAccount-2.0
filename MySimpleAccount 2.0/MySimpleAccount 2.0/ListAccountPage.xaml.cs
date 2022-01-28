using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для ListAccountPage.xaml
    /// </summary>
    public partial class ListAccountPage : Page
    {
        public ListAccountPage()
        {
            InitializeComponent();
            DataContext = new ListAccountViewModel();
        }
    }
}
