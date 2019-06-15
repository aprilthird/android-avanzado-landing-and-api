using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FDNE.LITE.ENTITIES.Models
{
    public class Horse
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public byte Sex { get; set; }

        public string UrlPicture { get; set; }

        public ICollection<Binomial> Binomials { get; set; }
    }
}
