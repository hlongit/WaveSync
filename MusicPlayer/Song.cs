using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer {
    public class Song {
        public int SongId { get; set; }
        public string Title { get; set; } = "";
        public string Artist { get; set; } = "";
        public string Album { get; set; } = "";
        public int DurationSeconds { get; set; }
        public string FilePath { get; set; } = "";      // e.g. "Music\song1.mp3"
        public string CoverPath { get; set; } = "";     // e.g. "Covers\cover1.jpg"
    }
}
