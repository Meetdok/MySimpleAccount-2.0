using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MySimpleAccount_2._0
{
    public class EditGameViewModel : INotifyPropertyChanged
    {
        private Game game;

        public Game Game
        {
            get => game;
            set
            {
                game = value;
                Signal();
            }
        }
        public CustomCommand AddGame { get; set; }
        public CustomCommand ListGame { get; set; }

        public CustomCommand GameListGame { get; set; }

        public EditGameViewModel(Game game)
        {
            Game = game;
            AddGame = new CustomCommand(() =>
            {
                if (!Data.Games.Contains(Game))
                    Data.Games.Add(Game);
                Game = new Game();
            }, () => true);

            ListGame = new CustomCommand(() =>
            {
                Data.CurrentPage = new GameListPage();
            }, () => true);

            GameListGame = new CustomCommand(() =>
            {
                Data.CurrentPage = new GameListPage();
            }, () => true);
        }

        public EditGameViewModel() : this(new Game())
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void Signal([CallerMemberName] string prop = null) =>
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(prop));
    }
}
