using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace BeatLeader3.Models
{
    public class Score
    {
        public int ScoreID { get; set; }

        public int BeatmapID { get; set; }

        [Required]
        public int Multiplier { get; set; }

        [Required]
        public string Rank { get; set; }

        [Required]
        public decimal Percentage { get; set; }

        [Required]
        public int? score { get; set; }

        [Required]
        public bool FullCombo { get; set; }
        public Beatmap Beatmap { get; set; }
        public Player Player { get; set; }


    }
}
