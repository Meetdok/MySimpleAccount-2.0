using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySimpleAccount_2._0
{
    internal class ListGameViewModel : INotifyPropertyChanged
    {
        private Game selectedGame;

        public CustomCommandTarget RemoveGame { get; set; }

        public CustomCommand EditGame { get; set; }
        public Game SelectedGame
        {
            get => selectedGame;
            set
            {
                selectedGame = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SelectedGame"));
            }
        }
        public ObservableCollection<Game> Games => Data.Games;

        public ListGameViewModel()
        {

            RemoveGame = new CustomCommandTarget((game) =>
            {
                var removing = (Game)game;
                Games.Remove(removing);
            });
            EditGame = new CustomCommand(
                () =>
                {
                    Data.CurrentPage = new EditGamePage(SelectedGame);
                }, () => SelectedGame != null);
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
