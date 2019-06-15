using System;
using System.Collections.Generic;
using System.Text;

namespace FDNE.LITE.ENTITIES.Models
{
    public class Result
    {
        public Guid Id { get; set; }

        public Guid BinomialId { get; set; }

        public Binomial Binomial { get; set; }

        public Guid ContestId { get; set; }

        public Contest Contest { get; set; }

        public double Score { get; set; }
    }
}
