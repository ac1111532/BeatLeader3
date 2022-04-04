using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace BeatLeader3.Models
{
    public class Beatmap
    {
        public int BeatmapID { get; set; }
        public int SongID { get; set; }

        [Range(0, 1500)]
        public int Notes { get; set; }

        [Range(0, 1500)]
        public int Walls { get; set; }

        [Range(0, 1500)]
        public int Bombs { get; set; }

        [Range(0, 1500)]
        public int Slash { get; set; }

        [Range(0, 150000)]
        public int MapPlays { get; set; }
        public Song song { get; set; }

        public ICollection<Score> Scores { get; set; }

    }
}