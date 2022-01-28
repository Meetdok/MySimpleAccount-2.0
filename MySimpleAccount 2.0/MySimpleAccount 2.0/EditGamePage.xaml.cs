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
    /// Логика взаимодействия для EditGamePage.xaml
    /// </summary>
    public partial class EditGamePage : Page
    {
        public EditGamePage()
        {
            InitializeComponent();
            DataContext = new EditGameViewModel();
        }
        public EditGamePage(Game selectedGame)
        {
            InitializeComponent();
            DataContext = new EditGameViewModel(selectedGame);
        }
    }
}
