using System;
using System.Collections.Generic;
using System.Text;

namespace FDNE.LITE.ENTITIES.Models
{
    public class Ranking
    {
        public Guid Id { get; set; }

        public Guid SeasonId { get; set; }

        public Season Season { get; set; }

        public Guid CategoryId { get; set; }

        public Category Category { get; set; }

        public ICollection<Binomial> Binomials { get; set; }
    }
}
