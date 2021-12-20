using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_Inheritance
{
    public class Song
    {
        private string artistName;

        private string songName;

        private int songMin;

        private int songSec;

        private string songLength;


        public string ArtistName
        {
            get { return artistName; }
            set
            {
                if (value.Length >= 3 && value.Length <= 20)
                    artistName = value;
                else
                    throw new InvalidArtistNameException("Artist name sholuld be between 2 and 20 symbols.");
            }
        }

        public string SongName
        {
            get { return songName; }
            set
            {
                if (value.Length < 3 || value.Length > 30)
                    throw new InvalidSongNameException("Song name should be betwween 3 and 30 symbols");

                //throw new InvalidSongException(); //ToDo När kan InvalidSongException inträffa???

                songName = value;
            }
        }

        public int SongMin
        {
            get { return songMin; }
            set
            {
                if (value < 0 || value > 14)
                    throw new InvalidSongMinutesException("Song minute should be between 0 and 14.");

                songMin = value;
            }
        }

        public int SongSec
        {
            get { return songSec; }
            set {
                if (value < 0 || value > 59)
                    throw new InvalidSongSecondsException("Song seconds should be between 0 and 59.");
                songSec = value; }
        }


        public string SongLength
        {
            get { return songLength; }
            set
            {
                var sl = value.Split(':', StringSplitOptions.RemoveEmptyEntries);
                if (sl.Length != 2 || !int.TryParse(sl[0], out int min) || !int.TryParse(sl[1], out int sec))
                    throw new InvalidSongLengthException("Invalid song length.");

                SongMin = min;
                SongSec = sec;

                songLength = value;
            }
        }




        public override string ToString()
        {
            return $"{ArtistName} {SongName} ";
        }

    }
}
