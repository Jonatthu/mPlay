using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Odasoft.mPlay.Models
{
    public class Album : Article
    {

        public virtual ICollection<Song> SongList { get; set; }

        public Album()
        {
            SongList = new List<Song>();
        }

       
    }
}
