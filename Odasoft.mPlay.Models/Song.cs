using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Odasoft.mPlay.Models
{
    public class Song
    {
        public int Id { get; set; }
        public virtual Album Album { get; set; }
        public string SongName { get; set; }
        public string SongLength { get; set; }

        #region  ForeignKeys
        public int AlbumId { get; set; }
        #endregion

    }
}
