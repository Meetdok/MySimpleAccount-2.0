using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySimpleAccount_2._0
{
    public class ListMusicViewModel : INotifyPropertyChanged
    {
        private Music selectedMusic;

        public CustomCommandTarget RemoveMusic { get; set; }

        public CustomCommand EditMusic { get; set; }
        public Music SelectedMusic
        {
            get => selectedMusic;
            set
            {
                selectedMusic = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SelectedMusic"));
            }
        }
        public ObservableCollection<Music> Musics => Data.Musics;

        public ListMusicViewModel()
        {

            RemoveMusic = new CustomCommandTarget((music) =>
            {
                var removing = (Music)music;
                Musics.Remove(removing);
            });
            EditMusic = new CustomCommand(
                () =>
                {
                    Data.CurrentPage = new EditMusicPage(SelectedMusic);
                }, () => SelectedMusic != null);
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
