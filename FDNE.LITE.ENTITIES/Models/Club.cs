using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FDNE.LITE.ENTITIES.Models
{
    public class Club
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public double Longitude { get; set; }

        public double Latitude { get; set; }

        public string Address { get; set; }

        public ICollection<Contest> Contests { get; set; }
    }
}
