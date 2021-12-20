using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_Inheritance
{
    public class RadioDB
    {
        List<Song> songs = new();

        public void AddSong(string songInfo)
        {
            var songInfos = songInfo.Split(';', StringSplitOptions.RemoveEmptyEntries);
            var song = new Song();
            song.ArtistName = songInfos[0];
            song.SongName = songInfos[1];
            song.SongLength = songInfos[2];

            songs.Add(song);
            Console.WriteLine("Song added.");
        }

        internal void SongsAdded()
        {
            Console.WriteLine($"Songs added: {songs.Count}");
        }

        internal void PlayListLength()
        {
            var totSec = 0;
            foreach(var song in songs)
            {
                totSec += song.SongMin * 60 + song.SongSec;

            }
            int h = totSec / 3600;
            int m = (totSec % 3600)/60;
            int s = totSec % 60;

            Console.WriteLine($"Playlist length: {totSec/3600}h {(totSec%(3600))/60}m {totSec%60}s");
        }

    }
}
