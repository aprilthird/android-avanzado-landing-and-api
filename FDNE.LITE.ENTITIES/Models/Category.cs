using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FDNE.LITE.ENTITIES.Models
{
    public class Category
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public Discipline Discipline { get; set; }

        public Guid DisciplineId { get; set; }

        public ICollection<Season> Seasons { get; set; }
    }
}
