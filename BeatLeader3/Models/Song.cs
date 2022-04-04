using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace BeatLeader3.Models
{
    public class Song
    {
        public int SongID { get; set; }

        [StringLength(30, MinimumLength = 3)]
        [Required]

        public string SongName { get; set; }

        [Range(0, 200)]
        [Required]
        public int SongLength { get; set; }

        [Range(0, 500)]
        [Required]
        public int SongBPM { get; set; }

        [Range(0, 100)]
        [Required]
        public int Size { get; set; }

        [StringLength(30, MinimumLength = 3)]
        [Required]
        public string Artist { get; set; }
        public Beatmap Beatmap { get; set; }


    }
}