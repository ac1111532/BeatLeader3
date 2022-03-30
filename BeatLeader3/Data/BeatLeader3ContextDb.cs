using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BeatLeader3.Models;

    public class BeatLeader3ContextDb : DbContext
    {
        public BeatLeader3ContextDb (DbContextOptions<BeatLeader3ContextDb> options)
            : base(options)
        {
        }

        public DbSet<BeatLeader3.Models.Beatmap> Beatmap { get; set; }

        public DbSet<BeatLeader3.Models.Song> Song { get; set; }

        public DbSet<BeatLeader3.Models.Score> Score { get; set; }

        public DbSet<BeatLeader3.Models.Player> Player { get; set; }
    }
