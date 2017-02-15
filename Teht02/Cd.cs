using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Cd
    {
        public string AlbumName { get; set; }
        public int AlbumPrice { get; set; }
        public string Artist { get; set; }

        //cd collection stores song-objects 
        private List<Song> cd;

        public Cd()
        {
            cd = new List<Song>();
        }

        /// <summary>
        /// Add songs to collection
        /// </summary>
        /// <param name="song">song to add</param>
        public void AddSong(Song song)
        {
            cd.Add(song);
        }

        public Song GetSong(int index)
        {
            if (index < cd.Count)
            {
                return cd.ElementAt(index);
            }
            else return null;
        }

       
        //prints data in cd
        public void PrintData()
        {
            Console.WriteLine(AlbumName + " \nHinta: " + AlbumPrice + " \nArtistilta: " + Artist + "\nsongs: ");
            foreach (Song song in cd)
            {
                Console.WriteLine("-"+song); //kirjoittaa song.ToString vastaavan
            }

        }
        public override string ToString()
        {
            return AlbumName + "  " + AlbumPrice + "  " + Artist;
        }
    }
}
    

