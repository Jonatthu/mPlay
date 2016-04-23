using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Odasoft.mPlay.Models
{
    public class Album : Article
    {
        public ICollection<Song> List { get; set; }
    }
}
