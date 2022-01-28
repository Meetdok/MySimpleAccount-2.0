using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MySimpleAccount_2._0
{
    static class Data
    {
        public static ObservableCollection<Account> Accounts = new ObservableCollection<Account>();
        public static ObservableCollection<Game> Games = new ObservableCollection<Game>();
        public static ObservableCollection<Music> Musics = new ObservableCollection<Music>();
        private static Page currentPage;
        public static event EventHandler CurrentPageChanged;
        public static Page CurrentPage
        {
            get => currentPage;
            internal set
            {
                currentPage = value;
                CurrentPageChanged?.Invoke(CurrentPage, new EventArgs());
            }
        }
    }
}
