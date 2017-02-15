using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            //create cd (collection)
            Cd cd = new Cd();
            cd.AlbumName = "Mahtihitit vol 1.";
            cd.AlbumPrice = 50;
            cd.Artist = "Make Mustajarven & kaverit";


            //create a few song objects
            Song song1 = new Song
            {
                SongName = "Hippipolkka",
                SongLength = "3:21",
               
            };

            Song song2 = new Song
            {
                SongName = "Purkkapoppi",
                SongLength = "1:12",

            };

            Song song3 = new Song
            {
                SongName = "Kekkulijazz",
                SongLength = "1:23",

            };

            Song song4 = new Song
            {
                SongName = "Siantappohevipiisi",
                SongLength = "7:06",

            };

            
            //add Song objects to Cd (cd)
            cd.AddSong(song1);
            cd.AddSong(song2);
            cd.AddSong(song3);
            cd.AddSong(song4);

           

            //print collection
            cd.PrintData();

          
        }
    }
}
