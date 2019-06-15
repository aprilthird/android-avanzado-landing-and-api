using System;
using System.Collections.Generic;
using System.Text;

namespace FDNE.LITE.ENTITIES.Models
{
    public class Season
    {
        public Guid Id { get; set; }

        public DateTime StartTime { get; set;  }

        public DateTime EndTime { get; set; }

        public int Year { get; set; }

        public ICollection<Ranking> Rankings { get; set; }
    }
}
