using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MySimpleAccount_2._0
{
    public class EditAccountViewModel : INotifyPropertyChanged
    {
        private Account account;

    public Account Account
    {
        get => account;
        set
        {
            account = value;
            Signal();
        }
    }
    public CustomCommand AddAccount { get; set; }
    public CustomCommand ListAccount { get; set; }
    public CustomCommand GameListAccount { get; set; }
        public CustomCommand ListMusicAccount { get; set; }

        public EditAccountViewModel(Account account)
    {
        Account = account;
        AddAccount = new CustomCommand(() =>
        {
            if (!Data.Accounts.Contains(Account))
                Data.Accounts.Add(Account);
            Account = new Account();
        }, () => true);

        ListAccount = new CustomCommand(() =>
        {
            Data.CurrentPage = new ListAccountPage();
        }, () => true);

            GameListAccount = new CustomCommand(() =>
            {
                Data.CurrentPage = new GameListPage();
            }, () => true);

            ListMusicAccount = new CustomCommand(() =>
            {
                Data.CurrentPage = new ListMusicPage();
            }, () => true);
        }

    public EditAccountViewModel() : this(new Account())
    {
    }

    public event PropertyChangedEventHandler PropertyChanged;
    void Signal([CallerMemberName] string prop = null) =>
        PropertyChanged?.Invoke(this,
            new PropertyChangedEventArgs(prop));
}
}
