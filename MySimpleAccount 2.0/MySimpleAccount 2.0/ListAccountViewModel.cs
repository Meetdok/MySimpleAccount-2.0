using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MySimpleAccount_2._0
{
    internal class ListAccountViewModel : INotifyPropertyChanged
    {
        private Account selectedAccount;

        public CustomCommandTarget RemoveAccount { get; set; }

        public CustomCommand EditAccount { get; set; }
        public Account SelectedAccount
        {
            get => selectedAccount;
            set
            {
                selectedAccount = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SelectedAccount"));
            }
        }
        public ObservableCollection<Account> Accounts => Data.Accounts;

        public ListAccountViewModel()
        {

            RemoveAccount = new CustomCommandTarget((account) =>
            {
                var removing = (Account)account;
                Accounts.Remove(removing);
            });
            EditAccount = new CustomCommand(
                () =>
                {
                    Data.CurrentPage = new EditAccountPage(SelectedAccount);
                }, () => SelectedAccount != null);
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
