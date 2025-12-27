using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer {
    // Used to represent a song in the music player, after being loaded from the database, check MainForm.cs
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
