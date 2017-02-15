using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Song
    {

        public string SongName { get; set; }
       
        public string SongLength { get; set; }

        public override string ToString()
        {
            return SongName + " " + SongLength;
        }
    }
}

  
