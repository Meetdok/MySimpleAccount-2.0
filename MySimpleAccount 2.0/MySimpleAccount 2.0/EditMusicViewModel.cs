using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MySimpleAccount_2._0
{
    public class EditMusicViewModel : INotifyPropertyChanged
    {
        private Music music;

        public Music Music
        {
            get => music;
            set
            {
                music = value;
                Signal();
            }
        }
        public CustomCommand AddAccount { get; set; }

        public CustomCommand MusicListAccount { get; set; }

        public EditMusicViewModel(Music music)
        {
            Music = music;
            AddAccount = new CustomCommand(() =>
            {
                if (!Data.Musics.Contains(Music))
                    Data.Musics.Add(Music);
                Music = new Music();
            }, () => true);

            MusicListAccount = new CustomCommand(() =>
            {
                Data.CurrentPage = new ListMusicPage();
            }, () => true);
        }

        public EditMusicViewModel() : this(new Music())
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void Signal([CallerMemberName] string prop = null) =>
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(prop));
    }
}
