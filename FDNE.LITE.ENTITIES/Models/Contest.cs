using System;
using System.Collections.Generic;
using System.Text;

namespace FDNE.LITE.ENTITIES.Models
{
    public class Contest
    {
        public Guid Id { get; set; }

        public Guid ClubId { get; set; }

        public Club Club { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public ICollection<Result> Results { get; set; }
    }
}
