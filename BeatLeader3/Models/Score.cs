using System;
using System.Collections.Generic;

namespace BeatLeader3.Models
{
    public class Score
    {
        public int ScoreID { get; set; }
        public int Multiplier { get; set; }
        public string Rank { get; set; }
        public decimal Percentage { get; set; }
        public int score { get; set; }
        public bool FullCombo { get; set; }
        public Beatmap Beatmap { get; set; }
        public Player Player { get; set; }


    }
}
