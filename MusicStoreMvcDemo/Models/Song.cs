using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStoreMvcDemo.Models
{
    public class Song
    {
        public int SongId { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
    }
}