using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace BeatLeader3.Models
{
    public class Player
    {
        public int PlayerID { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string PlayerName { get; set; }

        [Required]
        public int AccountAge { get; set; }

        [Required]
        public string PlayerHMD { get; set; }

        [Required]
        public string PlayerPlatform { get; set; }

        [Required]
        [Range(0, 300)]
        public int Modcount { get; set; }

        [Required]
        [Range(0, 10000)]
        public int LevelsBeaten { get; set; }
        public ICollection<Score> Scores { get; set; }

    }
}