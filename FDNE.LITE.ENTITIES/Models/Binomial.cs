using System;
using System.Collections.Generic;
using System.Text;

namespace FDNE.LITE.ENTITIES.Models
{
    public class Binomial
    {
        public Guid Id { get; set; }

        public string RiderId { get; set; }

        public ApplicationUser Rider { get; set; }

        public Guid HorseId { get; set; }

        public Horse Horse { get; set; }

        public Ranking Ranking { get; set; }

        public Guid RankingId { get; set; }

        public ICollection<Result> Results { get; set; }
    }
}
