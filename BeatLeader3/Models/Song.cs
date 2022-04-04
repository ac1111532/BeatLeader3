using System;
using System.Collections.Generic;

namespace BeatLeader3.Models
{
    public class Song
    {
        public int SongID { get; set; }
        public string SongName { get; set; }
        public int SongLength { get; set; }
        public int SongBPM { get; set; }
        public int Size { get; set; }
        public string Artist { get; set; }
        public Beatmap Beatmap { get; set; }


    }
}